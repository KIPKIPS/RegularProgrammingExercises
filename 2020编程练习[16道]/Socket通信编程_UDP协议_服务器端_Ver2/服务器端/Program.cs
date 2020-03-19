using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 服务器端 {
    class Program {
        static void Main(string[] args) {
            //创建UDP客户端,并绑定IP地址和端口号
            UdpClient udpClient=new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.1.23"), 7788));
            while (true) {
                //接受数据
                IPEndPoint remoteEndPoint=new IPEndPoint(IPAddress.Any,0);//允许任何地址和端口
                byte[] data=udpClient.Receive(ref remoteEndPoint);
                string message = Encoding.UTF8.GetString(data, 0, data.Length);
                Console.WriteLine(message);
                if (message== "Shutdown Connect") {
                    break;
                }
            }

            udpClient.Close();
        }
    }
}
