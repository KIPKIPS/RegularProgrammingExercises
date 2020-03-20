using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._087_继承 {
    class Program {
        static void Main(string[] args) {
        }
    }

    class Animal {
        public string name;

        public Animal(string name) {
            this.name = name;
        }
    }

    class Dog : Animal {

        //在构造方法执行之前先去调用父类的有参构造方法
        public Dog() :base(""){

        }
    }
}
