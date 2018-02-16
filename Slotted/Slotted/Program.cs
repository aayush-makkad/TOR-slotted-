using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Slotted
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.firstSock();
            Thread.Sleep(2000);
            p.secondSock();
            Thread.Sleep(2000);
            p.thirdSock();
            Thread.Sleep(2000);
            p.fourthSock();
            Thread.Sleep(2000);
            p.fifthSock();
            Thread.Sleep(2000);
            p.sixthSock();
            Thread.Sleep(1000);
            Console.WriteLine("transmission ended!");
            Console.Read();
           
        }

        void firstSock()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2000);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Bind(ipe);
            sc.Listen(10);
            Socket acc = sc.Accept();
            string s = "first"; 
            byte[] buffer = Encoding.ASCII.GetBytes(s);
            acc.Send(buffer, 0, buffer.Length, 0);
            
            //sc.Dispose();
            //acc.Dispose();
        }

        void secondSock()
        {
            
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2001);
                Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sc.Bind(ipe);
                sc.Listen(10);
                Socket acc = sc.Accept();
                string s = "second";
                byte[] buffer = Encoding.ASCII.GetBytes(s);
                acc.Send(buffer, 0, buffer.Length, 0);
                
            
        }

        void thirdSock()
        {
            
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2002);
                Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sc.Bind(ipe);
                sc.Listen(10);
                Socket acc = sc.Accept();
                string s = "third";
                byte[] buffer = Encoding.ASCII.GetBytes(s);
                acc.Send(buffer, 0, buffer.Length, 0);
               
            
        }

        void fourthSock()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2003);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Bind(ipe);
            sc.Listen(10);
            Socket acc = sc.Accept();
            string s = "fourth";
            byte[] buffer = Encoding.ASCII.GetBytes(s);
            acc.Send(buffer, 0, buffer.Length, 0);
            
        }

        void fifthSock()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2004);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Bind(ipe);
            sc.Listen(10);
            Socket acc = sc.Accept();
            string s = "fifth";
            byte[] buffer = Encoding.ASCII.GetBytes(s);
            acc.Send(buffer, 0, buffer.Length, 0);
           
        }

        void sixthSock()
        {
            
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2005);
                Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sc.Bind(ipe);
                sc.Listen(10);
                Socket acc = sc.Accept();
                string s = "sixth";
                byte[] buffer = Encoding.ASCII.GetBytes(s);
                acc.Send(buffer, 0, buffer.Length, 0);
               
            
        }
    }
}