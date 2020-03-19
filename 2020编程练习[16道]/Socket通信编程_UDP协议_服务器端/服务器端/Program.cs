using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 服务器端 {
    class Program {
        private static Socket udpServer;
        static void Main(string[] args) {
            //创建Socket
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //绑定IP和端口号
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.23"), 7788));

            new Thread(ReceiveMessage) { IsBackground = true }.Start();
            //udpServer.Close();
            Console.ReadLine();
        }

        static void ReceiveMessage() {
            while (true) {
                //接受数据
                Byte[] data = new byte[1024];
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                int length = udpServer.ReceiveFrom(data, ref remoteEndPoint); //第二个参数为数据来源
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine(message + "(数据来源:IP:" + ((IPEndPoint)remoteEndPoint).Address + " Port:" + ((IPEndPoint)remoteEndPoint).Port + ")");
            }

        }
    }
}