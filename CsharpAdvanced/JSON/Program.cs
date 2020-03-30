using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON {
    public class Skill {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
    }
    class Program {
        static void Main(string[] args) {

            string jsonText = "[{\"id\":2,\"name\":\"卢登的回声\",\"damage\":100},{\"id\":3,\"name\":\"最后的轻语\",\"damage\":500},{\"id\":4,\"name\":\"海克斯科技枪刃\",\"damage\":400}]";
            //Console.WriteLine(jsonText);
            Skill[] skills = JsonConvert.DeserializeObject<Skill[]>(jsonText);
            Console.WriteLine("id" + "\t" + "name" + "\t\t" + "damage");
            foreach (Skill s in skills) {
                Console.WriteLine(s.ID + "\t" + s.Name + "\t" + s.Damage);
            }
            Skill mySkill = new Skill {
                ID= 6,Name="冰川增幅",Damage = 100
            };
            string jsonMySkill=JsonConvert.SerializeObject(mySkill);
            Console.WriteLine(jsonMySkill);
            //写入json文件
            StreamWriter writer=new StreamWriter("Skill.json");
            writer.Write(jsonMySkill);
            writer.Close();
            Console.ReadKey();
        }
    }

}
