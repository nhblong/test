﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Text;

namespace Test1
{
    class TestServer
    {
        static void Main(string[] args)
        {
            //1. Create
            TcpClient client = new TcpClient();
            //2. Connect
            client.Connect("127.0.0.1", 8888);
            //3. Get Stream
            NetworkStream stream = client.GetStream();
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            //4. Send data
            byte[] data = Encoding.ASCII.GetBytes(name);
            stream.Write(data, 0, data.Length);
            //5. Receive Data
            byte[] dataReceive = new byte[1024];
            stream.Read(dataReceive, 0, 1024);
            Console.WriteLine("Server return: \"" + Encoding.ASCII.GetString(dataReceive) + "\"");
            //6. Close
            stream.Close();
            client.Close();
			//7. TODO: need to add your code
			Console.WriteLine("Hey reviewers next step");
        }
    }
}
