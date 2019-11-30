namespace 抽象类实现状态机 {

    //定义电梯行为：打开、关闭、运行、停止,即电梯包含的状态有四种,打开,关闭,运行,停止
    public abstract class LiftState {
        //用于更新当前状态
        protected Lift mLift;
        //通过构造函数引入实例化对象
        public LiftState(Lift lift) {
            mLift = lift;
        }
        //打开
        public abstract void Open();
        //关闭
        public abstract void Close();
        //运行
        public abstract void Run();
        //停止
        public abstract void Stop();
    }
}