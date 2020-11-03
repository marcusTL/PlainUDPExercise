using System;

namespace PlainUPDSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UPDSender us = new UPDSender();
            us.Start();
            Console.ReadLine();
        }
    }
}
