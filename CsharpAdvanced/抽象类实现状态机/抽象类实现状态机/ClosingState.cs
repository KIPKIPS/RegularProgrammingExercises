using System;
namespace 抽象类实现状态机 {
    public class ClosingState : LiftState {
        public ClosingState(Lift lift) : base(lift) {
        }
        //重写状态方法
        public override void Open() {
            //先将电梯设置为打开状态
            mLift.SetState(mLift.GetClosingState());
            //执行打开操作
            mLift.Open();
        }
        public override void Close() {
            Console.WriteLine("执行关门动作");
        }
        public override void Run() {
            // 运行动作
            // 1、运行状态
            mLift.SetState(mLift.GetRunningState());
            // 2、运行动作
            mLift.Run();
        }
        public override void Stop() {
            // 停止动作
            // 1、转化为停止状态
            mLift.SetState(mLift.GetStoppingState());
            // 2、停止
            mLift.Stop();
        }
    }
}