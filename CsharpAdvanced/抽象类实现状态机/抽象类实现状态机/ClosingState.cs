using System;
namespace 抽象类实现状态机 {
    public class ClosingState : LiftState {
        public ClosingState(Lift lift) : base(lift) {
        }
        public override void Open() {
            // 执行开门动作
            // 1、变化为开门状态
            this.mLift.SetState(mLift.GetClosingState());
            // 2、开门
            this.mLift.Open();
        }
        public override void Close() {
            Console.WriteLine("执行关门动作");
        }
        public override void Run() {
            // 运行动作
            // 1、运行状态
            this.mLift.SetState(mLift.GetRunningState());
            // 2、运行动作
            this.mLift.Run();
        }
        public override void Stop() {
            // 停止动作
            // 1、转化为停止状态
            this.mLift.SetState(mLift.GetStoppingState());
            // 2、停止
            this.mLift.Stop();
        }
    }
}