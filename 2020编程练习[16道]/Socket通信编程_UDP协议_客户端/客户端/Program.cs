using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 客户端 {
    class Program {
        static void Main(string[] args) {
            //创建Socket
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            while (true) {
                //发送数据
                string message = Console.ReadLine();
                byte[] data=Encoding.UTF8.GetBytes(message);
                EndPoint remoteEndPoint=new IPEndPoint(IPAddress.Parse("192.168.1.23"), 7788);
                udpClient.SendTo(data, remoteEndPoint);
            }
            //udpClient.Close();
            //Console.ReadLine();
        }
    }
}
