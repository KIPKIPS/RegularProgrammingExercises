namespace 单例模式 {
    public class Singleton_01 {
        //写起来最简单
        //构造函数私有化(防止外界通过new关键字来创建实例)
        private Singleton_01() {

        }
        public static readonly Singleton_01 instance=new Singleton_01();
    }
}