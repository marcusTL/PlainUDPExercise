using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using ModelLib;

namespace JsonUDPSender
{
    class JsonUDPSenderWorker
    {
        public void Start()
        {
            UdpClient client = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 11002);

            Car c1 = new Car("T1", "White", 80085);

            string sendStr = JsonSerializer.Serialize(c1);

            Byte[] Buffer = Encoding.UTF8.GetBytes(sendStr.ToCharArray());
            client.Send(Buffer, Buffer.Length, endPoint);
        }
    }
}
