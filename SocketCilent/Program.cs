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
            clientSocket.ConnectServer("192.168.25.124", 8078);
            clientSocket.SendMessage(Console.ReadLine());
            Console.ReadKey();
        }
        
    }
}
