using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 客户端 {
    class Program {
        static void Main(string[] args) {
            //创建对象的同时,建立连接
            TcpClient client=new TcpClient("192.168.1.23",7788);
            NetworkStream stream = client.GetStream();//通过网络数据流进行数据交换
            //read读取数据,write来写入
            while (true) {
                string message = Console.ReadLine();
                if (message== "Shutdown Connect") {
                    break;
                }
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            
            //关闭连接,释放资源
            stream.Close();
            client.Close();

        }
    }
}
