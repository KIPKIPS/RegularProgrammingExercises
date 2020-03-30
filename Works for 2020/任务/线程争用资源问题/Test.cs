using System;

namespace 线程争用资源问题 {
    public class Test {
        private int state = 5;

        public void ChangeState() {
            state++;
            if (state==5) {
                Console.WriteLine("state=5");
            }
            state = 5;
        }
    }
}