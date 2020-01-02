using System;

namespace 状态模式 {
    public class EatState : AnimalState {

        public EatState(Animal animal):base(animal) {

        }
        public override void Eat() {
            Console.WriteLine("Animal is eating");
        }

        public override void Sleep() {
            animal.SetState(animal.GetSleepState());
            animal.Sleep();
        }
    }
}