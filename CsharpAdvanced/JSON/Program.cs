using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON {
    public class Skill {
        public int id { get; set; }
        public string name { get; set; }
        public int damage { get; set; }
    }
    class Program {
        static void Main(string[] args) {

            string jsonText = "[{\"id\":2,\"name\":\"卢登的回声\",\"damage\":100},{\"id\":3,\"name\":\"最后的轻语\",\"damage\":500},{\"id\":4,\"name\":\"海克斯科技枪刃\",\"damage\":400}]";
            //Console.WriteLine(jsonText);
            //序列化json字符串
            Skill[] skills = JsonConvert.DeserializeObject<Skill[]>(jsonText);
            Console.WriteLine("id" + "\t" + "name" + "\t\t" + "damage");
            foreach (Skill s in skills) {
                Console.WriteLine(s.id + "\t" + s.name + "\t" + s.damage);
            }
            //对象
            Skill mySkill = new Skill {
                id= 6,name="冰川增幅",damage = 100
            };
            //将对象转换为json文本
            string jsonMySkill=JsonConvert.SerializeObject(mySkill);
            Console.WriteLine(jsonMySkill);
            //将转换过后的json字符串写入json文件
            StreamWriter writer=new StreamWriter("Skill.json");
            writer.Write(jsonMySkill);//写入文件
            writer.Close();

            //读取文件
            StreamReader reader=new StreamReader(@"E:\Regular_Programming_Exercises\CsharpAdvanced\JSON\JSON技能信息.json");
            string end = reader.ReadToEnd();
            end = end.Substring(0, end.Length - 3);
            reader.Close();
            //新建写入流,true代表不覆盖源文件
            writer=new StreamWriter(@"E:\Regular_Programming_Exercises\CsharpAdvanced\JSON\JSON技能信息.json");
            writer.WriteLine(end+",");
            writer.WriteLine(jsonMySkill+"]");
            writer.Close();

            reader = new StreamReader(@"E:\Regular_Programming_Exercises\CsharpAdvanced\JSON\JSON技能信息.json");
            string skillText = reader.ReadToEnd();
            //Console.WriteLine(skillText);
            Skill[] newSkill = JsonConvert.DeserializeObject<Skill[]>(skillText);
            foreach (Skill s in newSkill) {
                Console.WriteLine(s.id + "\t" + s.name + "\t" + s.damage);
            }
            Console.ReadKey();
        }
    }

}
