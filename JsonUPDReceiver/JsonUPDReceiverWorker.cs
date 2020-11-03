using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ModelLib;

namespace JsonUPDReceiver
{
    class JsonUPDReceiverWorker
    {
        public void Start()
        {
            UdpClient client = new UdpClient(11002);

            Byte[] buffer;

            while (true)
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                

                buffer = client.Receive(ref endPoint);

                var recieveData = Encoding.UTF8.GetString(buffer);
                var c2 = JsonSerializer.Deserialize<Car>(recieveData);

                Console.WriteLine(c2);
            }
        }
    }
}
