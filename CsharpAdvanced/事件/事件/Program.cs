using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件 {
    /// <summary>
    /// 委托
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ProcessDelegate(object sender, EventArgs e);
    class Program {
        static void Main(string[] args) {
            /*  第一步执行  */
            Test t = new Test();
            /* 关联事件方法，相当于寻找到了委托人 */
            t.ProcessEvent += new ProcessDelegate(t_ProcessEvent);
            /* 进入Process方法 */
            Console.WriteLine(t.Process());

            Console.Read();
        }

        static void t_ProcessEvent(object sender, EventArgs e) {
            Test t = (Test)sender;
            t.Text1 = "Hello";
            t.Text2 = "World";
        }
    }

    public class Test {

        public string Text1 { get; set; }
        public string Text2 { get; set; }

        public event ProcessDelegate ProcessEvent;

        void ProcessAction(object sender, EventArgs e) {
            if (ProcessEvent == null)
                ProcessEvent += new ProcessDelegate(t_ProcessEvent);
            ProcessEvent(sender, e);
        }

        //如果没有自己指定关联方法，将会调用该方法抛出错误
        void t_ProcessEvent(object sender, EventArgs e) {
            throw new Exception("The method or operation is not implemented.");
        }

        void OnProcess() {
            ProcessAction(this, EventArgs.Empty);
        }

        public string Process() {
            OnProcess();
            return Text1 + Text2;
        }
    }
}
