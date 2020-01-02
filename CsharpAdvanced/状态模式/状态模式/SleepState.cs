using System;

namespace 状态模式 {
    public class SleepState : AnimalState {
        public SleepState(Animal animal) : base(animal) {

        }
        public override void Eat() {
            animal.SetState(animal.GetEatState());
            animal.Eat();
        }

        public override void Sleep() {
            Console.WriteLine("Animal is sleeping");
        }
    }
}