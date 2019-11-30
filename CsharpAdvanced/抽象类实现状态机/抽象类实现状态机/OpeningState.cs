using System;
namespace 抽象类实现状态机 {
    public class OpeningState : LiftState {
        public OpeningState(Lift lift):base(lift) {

        }
        public override void Open() {
            // 执行开门动作
            Console.WriteLine("执行开门动作");
        }
        public override void Close() {
            //先将电梯状态转换成关闭态
            mLift.SetState(mLift.GetClosingState());
            // 执行关闭动作
            mLift.Close();
        }
        public override void Run() {
            // do noting
            // 开门状态 不能执行运行动作
        }

        public override void Stop() {
            // do noting
            // 开门状态下 不执行停止动作
        }
    }
}