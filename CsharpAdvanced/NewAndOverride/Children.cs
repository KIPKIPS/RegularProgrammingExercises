using System;

namespace NewAndOverride {
    public class Children:Father {
        //public override void Func() {
            //Console.WriteLine("Children类override的Father类的方法");
        //}
        public new void Func() {
            Console.WriteLine("Children类new的Father类的方法");
        }
    }
}