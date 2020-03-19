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
            //新建Listerner,封装了Socket
            TcpListener listener=new TcpListener(IPAddress.Parse("192.168.1.23"),7788);
            //开始监听
            listener.Start();
            //等待客户端连接
            TcpClient client = listener.AcceptTcpClient();
            //取得客户端发送的数据
            NetworkStream stream=client.GetStream();//得到一个数据流,该流可以获得客户端的数据
            while (true) {
                //读取数据
                byte[]data=new byte[1024];//数据容器
                int length=stream.Read(data,0,1024);
                string message = Encoding.UTF8.GetString(data,0, length);
                Console.WriteLine(message);
                if (message=="Shutdown Connect") {
                    break;
                }
            }

            //关闭三个资源
            stream.Close();
            client.Close();
            listener.Stop();
            Console.ReadLine();
        }
    }
}
