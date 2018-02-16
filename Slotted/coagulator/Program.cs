using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace coagulator
{
    class Program
    {
        byte[] buffer1 = new byte[2000];
        byte[] buffer2 = new byte[2000];
        byte[] buffer3 = new byte[2000];
        byte[] buffer4 = new byte[2000];
        byte[] buffer5 = new byte[2000];
        byte[] buffer6 = new byte[2000];
        byte[] outgoing1 = new byte[4000];
        byte[] outgoing2 = new byte[4000];
        byte[] outgoing3 = new byte[4000];

        static void Main(string[] args)
        {
            Program p = new Program();
            p.firstSockAcc();
            Thread.Sleep(1990);
            p.secondSockAcc();
            Thread.Sleep(1990);
            if (p.outgo())
            {
                p.thirdtSockAcc();
                Thread.Sleep(1990);
                p.fourthSockAcc();
                Thread.Sleep(1990);
                if (p.outgo2())
                {
                    p.fifthSockAcc();
                    Thread.Sleep(1990);
                    p.sixthtSockAcc();
                    //Thread.Sleep(1990);
                    p.outgo3();
                }
            }

            
        }

        void firstSockAcc()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2000);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer1, 0, buffer1.Length, 0);
            Array.Resize(ref buffer1, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer1);
            Console.WriteLine(str);
            sc.Dispose();

        }

        void secondSockAcc()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2001);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer2, 0, buffer2.Length, 0);
            Array.Resize(ref buffer2, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer2);
            Console.WriteLine(str);

        }

        void thirdtSockAcc()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2002);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer3, 0, buffer3.Length, 0);
            Array.Resize(ref buffer3, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer3);
            Console.WriteLine(str);

        }

        void fourthSockAcc()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2003);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer4, 0, buffer4.Length, 0);
            Array.Resize(ref buffer4, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer4);
            Console.WriteLine(str);

        }

        void fifthSockAcc()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2004);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer5, 0, buffer5.Length, 0);
            Array.Resize(ref buffer5, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer5);
            Console.WriteLine(str);

        }

        void sixthtSockAcc()
        {

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2005);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Connect(ipe);
            int rec = sc.Receive(buffer6, 0, buffer6.Length, 0);
            Array.Resize(ref buffer6, rec);
            string str = System.Text.Encoding.ASCII.GetString(buffer6);
            Console.WriteLine(str);

        }

        bool outgo()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Bind(ipe);
            sc.Listen(10);
            Socket acc = sc.Accept();
            acc.Send(buffer1, 0, buffer1.Length, 0);
            //sc.Dispose();
            //acc.Dispose();
            //second

            IPEndPoint ipe2 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1001);
            Socket sc2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc2.Bind(ipe2);
            sc2.Listen(10);
            Socket acc2 = sc2.Accept();
            acc2.Send(buffer2, 0, buffer2.Length, 0);
            //sc2.Dispose();
            //acc2.Dispose();

            return true;
        }

        bool outgo2()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1002);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Bind(ipe);
            sc.Listen(10);
            Socket acc = sc.Accept();
            acc.Send(buffer3, 0, buffer3.Length, 0);
            //sc.Dispose();
            //acc.Dispose();
            //second

            IPEndPoint ipe2 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1003);
            Socket sc2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc2.Bind(ipe2);
            sc2.Listen(10);
            Socket acc2 = sc2.Accept();
            acc2.Send(buffer4, 0, buffer4.Length, 0);
            //sc2.Dispose();
            //acc2.Dispose();

            return true;
        }
        bool outgo3()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1004);
            Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc.Bind(ipe);
            sc.Listen(10);
            Socket acc = sc.Accept();
            acc.Send(buffer5, 0, buffer5.Length, 0);
            //sc.Dispose();
            //acc.Dispose();
            //second

            IPEndPoint ipe2 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1005);
            Socket sc2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sc2.Bind(ipe2);
            sc2.Listen(10);
            Socket acc2 = sc2.Accept();
            acc2.Send(buffer6, 0, buffer6.Length, 0);
            //sc2.Dispose();
            //acc2.Dispose();

            return true;
        }

    }
}