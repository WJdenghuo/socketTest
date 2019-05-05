using ClassLibrary1;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketCilent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClientSocket clientSocket = ClientSocket.CreateInstance();
            clientSocket.ConnectServer("127.0.0.1", 8078);
            clientSocket.SendMessage("hello");
        }
        
    }
}
