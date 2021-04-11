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

        public bool IsStarted { get; set; } = false;

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

                    while (!IsStarted)
                    {
                        Thread.Sleep(500);
                    }
                    IsStarted = false;
                    
                    message = "Start";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                
                    Stream.Write(data, 0, data.Length); //Работай!

                    form.Pbars(Id, 0);
                    int value = 0;
                    while (true)
                    {
                    
                        Thread.Sleep(1000);

                        value += 10;
                        if (value >= 90)
                        {
                            value = 90;
                            try
                            {
                                message = GetMessage();
                                if (message == "Complete")
                                    break;
                            }
                            catch (Exception ex)
                            {
                                form.Status = ex.Message;
                                //throw new Exception(ex.Message);
                            }
                        }
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
                //throw new Exception(ex.Message);
            }
            finally
            {
                // в случае выхода из цикла закрываем ресурсы
                server.RemoveConnection(this.Id);
                Close();
            }
        }

        // чтение входящего сообщения и преобразование в строку
        private string GetMessage()
        {
            byte[] data = new byte[client.ReceiveBufferSize];
            int bytes = Stream.Read(data, 0, client.ReceiveBufferSize);
            if(bytes > 0)
            {
                // Строка, содержащая ответ от сервера
                string message = Encoding.UTF8.GetString(data, 0, bytes);

                return message;
            }
            else
            {
                Close();
                return null;
            }
            
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