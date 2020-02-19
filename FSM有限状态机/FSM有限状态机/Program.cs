using System;

namespace FSM有限状态机 {
    class Program {
        //定义所有状态
        public enum State {
            Wait,
            Move,
            Attack,
            Die
        }
        //声明当前状态
        private State currentState;
        //设置状态,状态转换函数
        public void SetState(State newState) {
            currentState = newState;
            switch (currentState) {
                case State.Wait:
                    WaitEnter();
                    break;
                case State.Move:
                    MoveEnter();
                    break;
                case State.Attack:
                    AttackEnter();
                    break;
                case State.Die:
                    DieEnter();
                    break;
            }
        }

        public void WaitEnter() {
        }
        public void MoveEnter() {
        }
        public void AttackEnter() {
        }
        public void DieEnter() {
        }

        public void Update() {
            switch (currentState) {
                case State.Wait:
                    DoWait();
                    break;
                case State.Move:
                    DoMove();
                    break;
                case State.Attack:
                    DoAttack();
                    break;
                case State.Die:
                    DoDie();
                    break;
            }
        }
        //主函数
        static void Main(string[] args) {
            Console.ReadLine();
        }
        public void DoWait() {
        }
        public void DoMove() {
        }
        public void DoAttack() {
        }
        public void DoDie() {
        }
    }
}
