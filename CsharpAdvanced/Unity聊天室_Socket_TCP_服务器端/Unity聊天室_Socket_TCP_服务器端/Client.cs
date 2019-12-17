using System;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Unity聊天室_Socket_TCP_服务器端 {
    //用来和客户端做通信
    public class Client {
        private Socket clientSocket;
        private Thread t;
        private byte[] data=new byte[1024];//数据容器
        public Client(Socket s) {
            clientSocket = s;
            t =new Thread(ReceiveMessage);
            t.Start();
        }
        //启动一个线程处理数据的接收
        private void ReceiveMessage() {
            //持续接收客户端的数据
            while (true) {
                //接收数据时判断连接是否断开,断开返回true,连接状态返回false
                if (clientSocket.Poll(10, SelectMode.SelectRead)) {
                    Console.WriteLine("Connected is shutdown");
                    clientSocket.Close();//关闭连接
                    break;//跳出循环,终止线程的执行
                }
                int length = clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                //TODO:接收到数据的时候,把这个数据分发到客户端;
                if (message!="") {
                    Console.WriteLine("Receive a message : " + message);
                }
            }
        }

        public void Send(string message) {
            clientSocket.Send(Encoding.UTF8.GetBytes(message));
        }
    }
}