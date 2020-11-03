using System;

namespace PlainUDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UPDReceiver ur = new UPDReceiver();
            ur.Start();
            Console.ReadLine();
        }
    }
}
