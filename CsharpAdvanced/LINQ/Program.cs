using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQ {
    class Program {
        static void Main(string[] args) {
            //初始化武林高手
            var masterList = new List<MartialArtsMaster>() {
                new MartialArtsMaster(){ Id =1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
                new MartialArtsMaster(){ Id =2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 10 },
                new MartialArtsMaster(){ Id =3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 7 },
                new MartialArtsMaster(){ Id =4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu = "葵花宝典",  Level = 1  },
                new MartialArtsMaster(){ Id =5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 8 },
                new MartialArtsMaster(){ Id =6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
                new MartialArtsMaster(){ Id =7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
                new MartialArtsMaster() { Id =8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
                new MartialArtsMaster() { Id =9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
                new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
                new MartialArtsMaster() { Id =11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
            };
            //初始化武学
            var kongfuList = new List<Kongfu>{
                new Kongfu(){KongfuId=1, KongfuName="打狗棒法", Lethality=90},
                new Kongfu(){KongfuId=2, KongfuName="降龙十八掌", Lethality=95},
                new Kongfu(){KongfuId=3, KongfuName="葵花宝典", Lethality=100},
                new Kongfu() { KongfuId=  4, KongfuName = "独孤九剑", Lethality = 100 },
                new Kongfu() { KongfuId = 5, KongfuName = "九阴真经", Lethality = 100 },
                new Kongfu() { KongfuId = 6, KongfuName = "弹指神通", Lethality = 100 }
            };

            //1查询所有级别大于8的,并放入res里面
            var res = new List<MartialArtsMaster>();
            foreach (var temp in masterList) {
                if (temp.Level > 8) {
                    res.Add(temp);
                }
            }
            //1.1查询所有级别大于8的,并放入res里面
            var resmore = new List<MartialArtsMaster>();
            foreach (var temp in masterList) {
                if (temp.Level > 8 && temp.Menpai == "丐帮") {
                    resmore.Add(temp);
                }
            }

            //2使用linq来查询
            var res1 = from m in masterList //m表示每一个masterList列表里的对象
                       where m.Level > 8
                       select m.Name;//返回m结果的集合

            //2.1多个查询条件,linq表达式查询
            var res1more = from m in masterList //m表示每一个masterList列表里的对象
                           where m.Level > 8 && m.Menpai == "丐帮"
                           select m.Name;//返回m结果的集合

            //3扩展的方法,过滤
            var res2 = masterList.Where(Test);
            //3.1扩展的方法,过滤
            var res2more = masterList.Where(Testmore);

            //4Lambda表达式
            var res3 = masterList.Where(m => m.Level > 8);

            //4.1Lambda表达式
            var res3more = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");




            //联合查询LINQ,从多个list里面查询
            var moreres = from m in masterList
                          from k in kongfuList
                          where m.Kongfu == k.KongfuName && k.Lethality > 95
                          //单个字段排序
                          //orderby m.Age ascending //descending //按照年龄倒序 descending 排序,默认为升序 ascending

                          //多个字段排序
                          orderby m.Level, m.Age //按照等级进行升序排列,如果等级相同按照年龄升序排列
                          //select new { master = m, kongfu = k };
                          select m;

            //扩展方法用法 单个字段排序 多List链接
            var more1res = masterList.SelectMany(m => kongfuList, (m, k) => new { master = m, kongfu = k })
                .Where(x => x.master.Kongfu == x.kongfu.KongfuName && x.master.Level > 8);
            //扩展方法用法 按照多个字段排序
            var more2res = masterList.Where(m => m.Level > 5).OrderBy(m => m.Age).ThenBy(m => m.Level);//orderBy之后按照thenBy排序
            //OrderByDescending 按照降序排列



            //5.join in 集合联合 on后面加查询条件 等于用equals
            var res4 = from m in masterList
                       join k in kongfuList on m.Kongfu equals k.KongfuName
                       where k.Lethality > 90
                       orderby m.Level, m.Age, k.KongfuId
                       select new { master = m, kongfu = k };

            //6.联合查询 分组查询 查询那个功夫修炼的人多
            var res5 = from k in kongfuList
                       join m in masterList on k.KongfuName equals m.Kongfu
                       into groups
                       orderby groups.Count()
                       select new { kongfu = k, count = groups.Count() };

            //7,分组
            var res6 = from m in masterList
                       group m by m.Kongfu
                into g
                       select new { count = g.Count(), key = g.Key };//g.Key表示按照那个属性分的组

            //8.量词操作符 判断是否符合条件
            string a = masterList.Any(m => m.Menpai == "丐帮") ? "有丐帮的人" : "没有丐帮的人";//Any方法是只要数据集之中有一个满足条件即可
            Console.WriteLine(a);
            var b = masterList.All(m => m.Menpai == "丐帮") ? "全是丐帮的人" : "不全是丐帮的人";//All方法是数据集所有的查询条件符合
            Console.WriteLine(b);

            //输出查询到的结果
            foreach (var temp in res6) {
                Console.WriteLine(temp.ToString() + "\t");
            }

            Console.ReadLine();
        }

        //3过滤的方法
        static bool Test(MartialArtsMaster master) {
            if (master.Level > 8) return true;
            return false;
        }

        //3.1过滤的方法
        static bool Testmore(MartialArtsMaster master) {
            if (master.Level > 8 && master.Menpai == "丐帮") return true;
            return false;
        }
    }
}
