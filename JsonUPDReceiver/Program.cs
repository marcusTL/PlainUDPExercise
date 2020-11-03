using System;

namespace JsonUPDReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonUPDReceiverWorker worker = new JsonUPDReceiverWorker();
            worker.Start();
            Console.ReadLine();
        }
    }
}
