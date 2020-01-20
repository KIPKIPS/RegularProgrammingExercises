using System;

namespace 状态模式 {
    public class SleepState : AnimalState {
        public SleepState(Animal animal) : base(animal) {

        }
        //设置当前状态
        public override void Eat() {
            animal.SetState(new EatState(animal));
            animal.Eat();
        }

        public override void Sleep() {
            Console.WriteLine("Animal is sleeping");
        }
    }
}