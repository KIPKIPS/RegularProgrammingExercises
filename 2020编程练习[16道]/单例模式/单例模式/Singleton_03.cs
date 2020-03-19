namespace 单例模式 {
    public class Singleton_03 {
        //静态，保存类的实例
        private static Singleton_03 instance;

        //公有变量
        public static Singleton_03 Instance {
            //匿名函数 
            get //赋值
            {
                if (instance == null) {
                    instance = new Singleton_03();
                }
                return instance;
            }
        }
    }
}