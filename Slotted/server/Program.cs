using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace server
{
    class Program
    {
        byte[] buffer1 = new byte[2000];
        byte[] buffer2 = new byte[2000];
        byte[] buffer3 = new byte[2000];
        byte[] buffer4 = new byte[2000];
        byte[] buffer5 = new byte[2000];
        byte[] buffer6 = new byte[2000];
        static void Main(string[] args)
        {
            Program p = new Program();
            p.accfirst();
            p.accsecond();
            Thread.Sleep(3999);
            p.accthird();
            p.accfourth();
            Thread.Sleep(3999);
            p.accfifth();
            p.accsixth();
            Console.Read();
            Console.Read();
            
        }

        void accfirst()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer1, 0, buffer1.Length, 0);
            Array.Resize(ref buffer1, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer1);
            Console.WriteLine(str);
            sc.Dispose();

        }
        void accsecond()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1001);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer2, 0, buffer2.Length, 0);
            Array.Resize(ref buffer2, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer2);
            Console.WriteLine(str);
            sc.Dispose();
        }
        void accthird()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1002);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer3, 0, buffer3.Length, 0);
            Array.Resize(ref buffer3, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer3);
            Console.WriteLine(str);
            sc.Dispose();
        }
        void accfourth()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1003);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer4, 0, buffer4.Length, 0);
            Array.Resize(ref buffer4, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer4);
            Console.WriteLine(str);
            sc.Dispose();
        }
        void accfifth()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1004);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer5, 0, buffer5.Length, 0);
            Array.Resize(ref buffer5, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer5);
            Console.WriteLine(str);
            sc.Dispose();
        }
        void accsixth()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1005);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer6, 0, buffer6.Length, 0);
            Array.Resize(ref buffer6, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer6);
            Console.WriteLine(str);
            sc.Dispose();
        }


    }
}