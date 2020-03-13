using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乐易网络笔试题 {
    class Program {
        struct TroopItem {
            public int id;
            public int type;//兵种
            public int level;//等级
            public int load;//装载值
            public int force;//战力
            public int own_num;//拥有数
            public int select_num;
        }
        static void Main(string[] args) {
            //步兵
            TroopItem infantry = new TroopItem {
                id = 1,
                level = 3,
                load = 1,
                own_num =40
            };
            //弓兵
            TroopItem archer = new TroopItem {
                id = 2,
                level = 4,
                load = 2,
                own_num = 30
            };
            //骑兵
            TroopItem sowar = new TroopItem {
                id = 3,
                level = 4,
                load = 3,
                own_num = 20
            };
            //攻城兵
            TroopItem Siege = new TroopItem {
                id = 4,
                level = 4,
                load = 4,
                own_num = 10
            };
            List<TroopItem> data=new List<TroopItem>();
            data.Add(infantry);
            data.Add(archer);
            data.Add(sowar);
            data.Add(Siege);
            List<TroopItem>res=QuickSelectTroopList(35, 34, data);
            for (int i = 0; i < res.Count; i++) {
                Console.Write(res[i].id+" "+res[i].select_num);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        //贪心算法,从拉取最多资源数的士兵开始拉取资源
        //有四个兵种(步兵，弓兵，骑兵，攻城兵)
        static List<TroopItem> QuickSelectTroopList(int res_max, int march_size_max, List<TroopItem> own_troop_list) {
            int loadSource = 4;
            int soldierNum = 1;
            List< TroopItem>res=new List<TroopItem>();
            for (int i = own_troop_list.Count-1; i >=0; i--) {
                Console.Write("type"+own_troop_list[i].id + " : ");
                for (int j = 1; j <=own_troop_list[i].own_num;++ j) {
                    if (loadSource >= res_max || soldierNum >= march_size_max) {
                        if (i==own_troop_list.Count-1) {
                            TroopItem temp = new TroopItem { id = own_troop_list[i].id, select_num = j };
                            res.Add(temp);
                        }
                        else {
                            TroopItem temp=new TroopItem{id=own_troop_list[i].id,select_num = j-1};
                        res.Add(temp);
                        }
                        break;
                    }
                    else {
                        if (j == own_troop_list[i].own_num) {
                            TroopItem temp = new TroopItem { id = own_troop_list[i].id, select_num = own_troop_list[i].own_num };
                            res.Add(temp);
                        }
                        else {
                            loadSource += own_troop_list[i].load;
                            ++soldierNum ;
                        }
                    }
                }
                Console.WriteLine("load: "+loadSource+" num: "+soldierNum);
                if (loadSource >= res_max || soldierNum >= march_size_max) {
                    break;
                }
            }
            return res;
        }
    }
}
