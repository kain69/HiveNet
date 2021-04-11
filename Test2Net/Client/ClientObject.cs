﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinForms.Windows;
using System.Drawing;

namespace WinForms.Client
{
    public class ClientObject
    {
        public bool IsConnect { get; private set; } = false;
        public string userName { get; set; }
        // Порт
        private const int port = 8005;
        public int Port { get { return port; } }
        // Адресс
        private const string address = "127.0.0.1";
        public string Address { get { return address; } }

        // Поток сообщений и TCP Client
        public TcpClient client { get; private set; }
        NetworkStream stream;

        // Форма
        public Form_Client form { get; set; }

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
                var t = client.Connected;
                client.Connect(address, port); //подключение клиента
                stream = client.GetStream(); // получаем поток

                form.Status = "Connected";

                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока

                form.ErrorText = "Хорошо!";
                form.ErrorColor = Color.Green;
            }
            catch (Exception ex)
            {
                form.ErrorText = ex.Message;
                form.ErrorColor = Color.Red;
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
                    if (!client.Connected)
                        throw new Exception("Ошибка: подключение прервано");
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

                    form.ErrorText = "Хорошо!";
                    form.ErrorColor = Color.Green;
                }
                catch
                {
                    if (form != null)
                    {
                        form.ErrorText = "Ошибка: подключение прервано";
                        form.ErrorColor = Color.Red;
                    }
                    Disconnect();
                    break;
                }
                if (message == "Start")
                {
                    Working();
                }
            }
        }

        public void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
            {
                
                client.Close();//отключение клиента
            }

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
