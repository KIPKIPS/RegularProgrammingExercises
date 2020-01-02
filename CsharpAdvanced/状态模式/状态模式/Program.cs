using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式 {
    class Program {
        static void Main(string[] args) {
            Animal animal=new Animal();
            animal.SetState(new SleepState(animal));
            animal.Eat();
            animal.Sleep();
            Console.ReadLine();
        }
    }
}
