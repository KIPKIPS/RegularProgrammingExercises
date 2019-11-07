using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_TCP_聊天室服务器端 {
    class Program {
        static List<Client>clientList=new List<Client>();//存储Client对象的集合
        static void Main(string[] args) {
            //创建Socket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //建立连接
            IPAddress address = IPAddress.Parse("10.18.59.166");
            EndPoint point = new IPEndPoint(address, 8000);
            tcpServer.Bind(point);
            //侦听连接消息
            tcpServer.Listen(100);
            Console.WriteLine("Server Started Succeed");

            while (true) {
                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("A Client Is Connected");
                Client client=new Client(clientSocket);//把每个客户端的通信逻辑放到Client类里面去处理
                clientList.Add(client);

                //转换收到的Byte数组类型的数据
                Byte[] data = new byte[1024];
                int length = clientSocket.Receive(data);
                Encoding.UTF8.GetString(data, 0, length);
            }
        }
    }
}
