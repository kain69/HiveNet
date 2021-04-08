using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinForms.Windows;

namespace WinForms.Client
{
    public class ClientObject
    {
        public string userName { get; set; }
        // Порт
        private const int port = 8005;
        public int Port { get { return port; } }
        // Адресс
        private const string address = "62.16.41.195";
        public string Address { get { return address; } }

        // Поток сообщений и TCP Client
        TcpClient client;
        NetworkStream stream;

        // Форма
        Form_Client form;

        public ClientObject(Form_Client form)
        {
            client = new TcpClient();
            this.form = form;
            userName = form.UserName; 
        }

        public void Connect()
        {
            
            try
            {
                client.Connect(address, port); //подключение клиента
                stream = client.GetStream(); // получаем поток

                form.Status = "Connected";

                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                form.Error = ex.Message;
                //throw new Exception(ex.Message);
            }
        }

        // отправка сообщений
        void SendMessage()
        {
            string message = "Complete";
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        // получение сообщений
        void ReceiveMessage()
        {
            while (true)
            {
                string message = null;
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    message = builder.ToString();
                }
                catch (Exception ex)
                {
                    form.Error = "Ошибка: подключение прервано";
                    Disconnect();
                    throw new Exception(ex.Message);
                }
                if (message == "Start")
                {
                    Working();
                }
            }
        }

        void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
        }

        void Working()
        {
            while (true)
            {
                if (form.progress >= 100)
                {
                    SendMessage();
                    break;
                }
                Thread.Sleep(1000);
                form.progress += 10;
            }
            Thread.Sleep(500);
            form.progress = 0;
        }
    }
}
