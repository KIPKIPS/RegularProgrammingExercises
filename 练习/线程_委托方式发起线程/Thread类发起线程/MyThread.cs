using System;
using System.Threading;

namespace Thread类发起线程 {
    public class MyThread {
        private string fileName;
        private string filePath;

        public MyThread(string fileName, string filePath) {
            this.fileName = fileName;
            this.filePath = filePath;
        }

        public void DownloadFile() {
            Console.WriteLine("Start to download "+fileName+" from "+filePath);
            Console.WriteLine("Downloading...");
            Thread.Sleep(1500);
            Console.WriteLine("Finished");
        }
    }
}