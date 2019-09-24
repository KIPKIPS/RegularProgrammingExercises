using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NO._086_单例模式 {
    class Program {
        static void Main(string[] args) {
        }
    }

    class User {
        private User() {
        }
        //单例模式一
        #region
        /*
        private static User instance = new User();//类启动时创建,静态的仅创建一次
        public static User CurrentUser() {
            return instance;
        }
        public static User Current {
            get { return instance; }
        }
        //CurrentUser和Current效果一致
        */
        #endregion

        //单例模式二
        #region
        /*
    private static User instance = new User();//类启动时创建,静态的仅创建一次
    public static User CurrentUser() {
        if (instance == null) { //什么时候需要什么时候去实例化这个类,避免不必要的内存浪费
            instance = new User();
        }
        return instance;
    }
    */
        #endregion

        //单例模式三
        //public的目的是外界也可以调用,static的目的是仅实例化一次,readonly的目的是外界无法修改instance
        public  static readonly User instance = new User();//类启动时创建,静态的仅创建一次,单例最简单的写法
    }
}
