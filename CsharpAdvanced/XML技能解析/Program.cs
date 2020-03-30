using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML技能解析 {
    class Program {
        static void Main(string[] args) {
            List<Skill>skills=new List<Skill>();
            XmlDocument xmlDoc=new XmlDocument();
            xmlDoc.Load("xml技能信息.xml");
            XmlNodeList skillList = xmlDoc.FirstChild.FirstChild.ChildNodes;//获取技能信息的列表
            foreach (XmlNode skill in skillList) {
                Skill temp=new Skill();
                //获取子标签的值
                if (skill["Name"]!=null) {
                    string name =skill["Name"].InnerText;
                    temp.Name = name;
                }
                //获取子标签的属性集合
                XmlAttributeCollection xac = skill.Attributes;
                if (xac!=null) {
                    temp.ID = Convert.ToInt32(xac["SkillID"].Value);
                    temp.EnglishName = xac["SkillEngName"].Value;
                    temp.TriggerType = Convert.ToInt32(xac["TriggerType"].Value);
                    temp.Image = xac["ImageFile"].Value;
                    temp.AvailableRace = Convert.ToInt32(xac["AvailableRace"].Value);
                }
                skills.Add(temp);
            }
            foreach (Skill skill in skills) {
                Console.WriteLine(skill.ID + "\t" + skill.Name + "\t" + skill.EnglishName + "\t" + skill.TriggerType + "\t" + skill.Image + "\t" + skill.AvailableRace);
            }
            Console.ReadLine();
        }
    }
}
