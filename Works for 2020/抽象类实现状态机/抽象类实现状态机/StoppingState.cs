using System;
namespace 抽象类实现状态机 {
    public class StoppingState : LiftState {
        //使用父类的构造方法
        public StoppingState(Lift lift) : base(lift) {
        }
        public override void Open() {
            // 开门动作
            // 1、开门状态
            mLift.SetState(mLift.GetOpeningState());
            // 2、执行开门动作
            mLift.Open();
        }
        public override void Close() {
            // do noting
        }
        public override void Run() {
            // 运行动作
            // 1、运行状态
            mLift.SetState(mLift.GetRunningState());
            // 2、运行动作
            mLift.Run();
        }
        public override void Stop() {
            // 电梯停止动作
            Console.WriteLine("电梯停止运行...");
        }


    }
}