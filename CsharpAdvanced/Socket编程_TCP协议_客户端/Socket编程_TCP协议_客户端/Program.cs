using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket编程_TCP协议_客户端 {
    class Program {
        static void Main(string[] args) {
            //1.创建socket
            Socket tcpClient=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //2.发起建立连接的请求
            IPAddress ipAddress = IPAddress.Parse("192.168.1.3");
            EndPoint point=new IPEndPoint(ipAddress,7788);
            tcpClient.Connect(point);//通过IP和端口号连接到服务器
            Byte[]data=new byte[1024];
            int length=tcpClient.Receive(data);//存取数据
            //length返回值表示接受了多少的数据
            Console.WriteLine("Receive a message: ");
            string message=Encoding.UTF8.GetString(data,0,length);//从0开始,到length结束,只把接受到的数据转换
            Console.WriteLine(message);
            //向服务器端发送消息      
            while (true) {
                
                string send = Console.ReadLine();
                if (send=="end"||send=="") {
                    break;
                }
                Console.WriteLine("Send a message:");
                tcpClient.Send(Encoding.UTF8.GetBytes(send));//发送客户端用户的输入
            }
            Console.ReadLine();
        }
    }
}
