using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
//服务器端
namespace Socket编程_TCP协议_服务器端 {
    class Program {
        static void Main(string[] args) {
            //1.创建Scoket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //2.绑定IP地址和端口号
            IPAddress ipAddress=new IPAddress(new byte[]{ 192,168,1,3 });
            EndPoint point=new IPEndPoint(ipAddress, 7788);//IPEndPoint是对IP和端口做了一层封装的类
            tcpServer.Bind(point);//向操作系统申请一个可用的IP和端口号用来做通信

            //3.开始监听
            Console.WriteLine("Start listening...");
            tcpServer.Listen(100);//等待客户端做连接,参数是客户端的最大连接数
            Socket clientSocket= tcpServer.Accept();//Accept暂停当前线程,直到有一个客户端连接,才会执行下面的代码
            //用返回的clientSocket和客户端做通信
            string message = "A client is connected";
            byte[] data=Encoding.UTF8.GetBytes(message);//对字符创做编码,得到该字符串的byte数组
            clientSocket.Send(data);//发送数据
            while (true) {
                Byte[] receive = new byte[1024];
                int length = clientSocket.Receive(receive);//用clientSocket来接受数据
                if (Encoding.UTF8.GetString(receive, 0, length)=="") {
                    break;
                }
                Console.WriteLine("Receive a message:");
                Console.WriteLine(Encoding.UTF8.GetString(receive,0,length));//接受到用户的输入
            }
            Console.ReadKey();
        }
    }
}