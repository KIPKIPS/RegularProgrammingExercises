namespace 单例模式 {
    public class Singleton_02 {
        //比较常用，且方便的一种
        //定义公有变量，提供全局访问
        public static Singleton_02 instance;

        //Start开始前执行函数
        public void Awake() {
            //容错
            if (instance != null) {
                //Destroy(instance);销毁实例
            }
            else {
                instance = this;
            }
        }
    }
}