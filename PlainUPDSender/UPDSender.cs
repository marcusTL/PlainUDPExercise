using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainUPDSender
{
    class UPDSender
    {
        public void Start()
        {
            UdpClient client = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 11001);

            Car c1 = new Car("T1","White",80085);

            string sendStr = c1.ToString();

            Byte[] Buffer = Encoding.UTF8.GetBytes(sendStr.ToCharArray());
            client.Send(Buffer, Buffer.Length, endPoint);

            //receiving the return message
            Byte[] rebuffer = client.Receive(ref endPoint);

            string receiveData = Encoding.UTF8.GetString(rebuffer);

            Console.WriteLine(receiveData);
        }
    }
}
