namespace 抽象类实现状态机 {
    //定义电梯类
    public class Lift {
        //定义出电梯的所有状态
        private LiftState openningState;
        private LiftState closingState;
        private LiftState runningState;
        private LiftState stoppingState;

        // 定义当前电梯状态
        private LiftState mCurState;
        //构造方法
        public Lift() {
            openningState = new OpeningState(this);
            closingState = new ClosingState(this);
            runningState = new RunningState(this);
            stoppingState = new StoppingState(this);
        }
        //执行开门动作
        public void Open() {
            mCurState.Open();
        }
        //执行关门动作
        public void Close() {
            mCurState.Close();
        }
        //执行运行动作
        public void Run() {
            mCurState.Run();
        }
        //执行停止动作
        public void Stop() {
            mCurState.Stop();
        }
        //设置当前电梯状态
        public void SetState(LiftState state) {
            this.mCurState = state;
        }
        //获取电梯的全部状态
        public LiftState GetOpeningState() {
            return openningState;
        }
        public LiftState GetClosingState() {
            return closingState;
        }
        public LiftState GetRunningState() {
            return runningState;
        }
        public LiftState GetStoppingState() {
            return stoppingState;
        }
    }
}