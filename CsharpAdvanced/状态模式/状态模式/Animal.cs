namespace 状态模式 {
    public class Animal {
        //定义对象包含的所有状态
        public AnimalState eatState;
        public AnimalState sleepState;

        //定义当前状态
        public AnimalState currentState;

        //构造函数
        public Animal() {
            eatState=new EatState(this);
            sleepState=new SleepState(this);
        }

        public void Eat() {
            currentState.Eat();//执行Eat函数
        }
        public void Sleep() {
            currentState.Sleep();//执行Sleep函数
        }
        //传入一个状态,将当前状态设置为这个状态
        public void SetState(AnimalState AS) {
            currentState = AS;
        }
    }
}