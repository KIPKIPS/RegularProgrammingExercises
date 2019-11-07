using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 抽象类实现状态机 {
    class Program {
        static void Main(string[] args) {
            Lift lift=new Lift();
            lift.SetState(new OpeningState(lift));
            lift.Open();
            lift.Close();
            lift.Run();
            lift.Stop();
            Console.ReadLine();
        }
    }
}
