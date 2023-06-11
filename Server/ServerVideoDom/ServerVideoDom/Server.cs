using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace ServerVideoDom
{
    class Server
    {
        TcpListener Listener; // Объект, принимающий TCP-клиентов
        // Запуск сервера
        public Server(int Port)
        {
                                                 // Создаем "слушателя" для указанного порта
            Listener = new TcpListener(IPAddress.Any, Port);  // IPAddress.Parse("")
            Listener.Start();                   // Запускаем его

            // В бесконечном цикле
            while (true)
            {
                // Принимаем нового клиента
                TcpClient Client = Listener.AcceptTcpClient();
                // Создаем поток
                Thread Thread = new Thread(new ParameterizedThreadStart(ClientThread));
                // И запускаем этот поток, передавая ему принятого клиента
                Thread.Start(Client);
            }
        }
        // Остановка сервера
        ~Server()
        {
            // Если "слушатель" был создан
            if (Listener != null)
            {
                // Остановим его
                Listener.Stop();
            }
        }
        static void ClientThread(Object StateInfo)
        {
            new Client((TcpClient)StateInfo);
        }
    }
}
