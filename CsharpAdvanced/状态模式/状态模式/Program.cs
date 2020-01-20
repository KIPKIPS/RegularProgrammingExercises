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
            Console.WriteLine("The current state of this animal is " + animal.currentState.ToString().Substring(5));
            animal.Sleep();
            Console.WriteLine("The current state of this animal is " + animal.currentState.ToString().Substring(5));
            Console.ReadLine();
        }
    }
}
