using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Socket_TCP_聊天室服务器端 {
    /// <summary>
    /// 用来和客户端做通信
    /// </summary>
    class Client {
        private Socket clientSocket;
        public Thread t;
        private Byte[] data=new byte[1024];//数据容器
        public Client(Socket s) {
            clientSocket = s;
            //启动一个线程,处理数据的接收
            t=new Thread(Receive);
            t.Start();
        }

        public void Receive() {
            while (true) {
                //接收数据之前要判断Socket连接是否断开
                if (clientSocket.Poll(10, SelectMode.SelectRead)) {
                    
                    break;//跳出循环,终止线程的执行
                }
                int length=clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                //TODO:接收到数据的时候,把这个数据分发到客户端;
                Console.WriteLine("收到了消息:"+message);
            }
        }

    }
}
