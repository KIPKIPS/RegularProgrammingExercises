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
            //创建client对象
            UdpClient udpClient=new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.1.23"), 0));

            while (true) {
                //发送消息
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                //目标地址和端口
                IPEndPoint target = new IPEndPoint(IPAddress.Parse("192.168.1.23"), 7788);
                udpClient.Send(data, data.Length, target);
                if (message=="Shutdown Connect") {
                    break;
                }
            }
            udpClient.Close();
        }
    }
}
