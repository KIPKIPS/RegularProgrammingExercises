namespace 状态模式 {
    public class Animal {
        public AnimalState eatState;
        public AnimalState sleepState;


        private AnimalState currentState;

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

        public AnimalState GetEatState() {
            return eatState;
        }
        public AnimalState GetSleepState() {
            return sleepState;
        }
    }
}