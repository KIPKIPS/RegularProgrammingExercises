namespace 抽象类实现状态机 {

    //定义电梯行为：打开、关闭、运行、停止,即电梯包含的状态有四种,打开,关闭,运行,停止
    public abstract class LiftState {
        // 拥有一个电梯对象，用于更新电梯当前状态
        protected Lift mLift;
        //通过构造函数引入电梯的实例化对象
        public LiftState(Lift lift) {
            this.mLift = lift;
        }
        //行为：打开电梯门
        public abstract void Open();
        // 行为：关闭电梯门
        public abstract void Close();
        //行为：电梯运行
        public abstract void Run();
        //行为：电梯停止运行
        public abstract void Stop();
    }
}