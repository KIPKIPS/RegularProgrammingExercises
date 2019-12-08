using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Unity聊天室_Socket_TCP_服务器端 {
    class Program {
        static List< Client>clientList=new List<Client>();
        static void Main(string[] args) {
            Socket tcpServer=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("10.17.129.101"), 7788 ));
            tcpServer.Listen(100);
            Console.WriteLine("Server is running");
            //循环等待客户端连接
            while (true) {
                Socket clientSocket = tcpServer.Accept();//接受客户端的Socket,并返回Socket类型
                Console.WriteLine("A client is connected");
                Client client=new Client(clientSocket);//把每个客户端通信逻辑(收发消息)放到Client里面去处理
                clientList.Add(client);
            }
        }
            
    }
}
