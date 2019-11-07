using System;
namespace 抽象类实现状态机 {
    public class RunningState : LiftState {
        public RunningState(Lift lift) : base(lift) {
        }
        public override void Open() {
            // do noting
        }
        public override void Close() {
            // do noting
        }
        public override void Run() {
            // 运行动作
            Console.WriteLine("电梯上下运行中...");
        }
        public override void Stop() {
            // 停止动作
            // 1、转化为停止状态
            mLift.SetState(mLift.GetStoppingState());
            // 2、停止动作
            mLift.Stop();
        }
    }
}