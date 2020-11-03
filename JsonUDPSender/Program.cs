using System;

namespace JsonUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonUDPSenderWorker worker = new JsonUDPSenderWorker();
            worker.Start();
            Console.ReadLine();
        }
    }
}
