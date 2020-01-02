namespace 状态模式 {
    public abstract class AnimalState {
        public Animal animal;

        //构造函数
        public AnimalState(Animal ani) {
            animal = ani;
        }
        //Animal类包含的状态
        public abstract void Eat();
        public abstract void Sleep();
    }
}