﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinForms.Server;
using WinForms.Windows;

namespace WinForms.Server
{
    public class ClientObject
    {
        protected internal int Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        ServerObject server; // объект сервера

        Form_Server form;

        public bool Flag { get; set; } = false;

        public ClientObject(TcpClient tcpClient, ServerObject serverObject, Form_Server form)
        {
            Id = serverObject.clients.Count;
            client = tcpClient;
            server = serverObject;
            // Добавить в список клиентов себя
            serverObject.AddConnection(this);

            this.form = form;
        }

        public void Process()
        {
            try
            {
                form.Status = "Кто-то подключился";
                Stream = client.GetStream();
                // получаем имя пользователя
                string message = GetMessage();
                userName = message;

                form.Names(Id, message);

                while (true) { 

                    while (!Flag)
                    {
                        Thread.Sleep(500);
                    }
                    Flag = false;

                    message = "Start";
                    byte[] data = Encoding.Unicode.GetBytes(message);
                
                    Stream.Write(data, 0, data.Length); //Работай!

                    form.Pbars(Id, 0);
                    int value = 0;
                    while (true)
                    {
                    
                        if (value >= 80)
                        {
                            try
                            {
                                message = GetMessage();
                                if (message == "Complete")
                                    break;
                            }
                            catch (Exception ex)
                            {
                                form.Status = ex.Message;
                                throw new Exception(ex.Message);
                            }
                            Thread.Sleep(100);
                            continue;
                        }
                        Thread.Sleep(1000);
                        value += 10;
                        form.Pbars(Id, value);
                    }
                    form.Pbars(Id, 100);
                    Thread.Sleep(1000);
                    form.Pbars(Id, 0);
                }
            }
            catch (Exception ex)
            {
                form.Status = ex.Message;
                throw new Exception(ex.Message);
            }
            //finally
            //{
            //    // в случае выхода из цикла закрываем ресурсы
            //    server.RemoveConnection(this.Id);
            //    Close();
            //}
        }

        // чтение входящего сообщения и преобразование в строку
        private string GetMessage()
        {
            byte[] data = new byte[64]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            string message = builder.ToString();

            return message;
        }

        // закрытие подключения
        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}