using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML {
    class Program {
        static void Main(string[] args) {
            List<Skill>skills=new List<Skill>();
            XmlDocument xml=new XmlDocument();

            //两种加载xml文档的方法
            //1
            //xml.Load("SkillInfo.xml");//解析路径下的xml文档
            //2
            xml.LoadXml(File.ReadAllText("SkillInfo.xml"));//获取xml文档的字符串
            
            //得到xml文档的根节点
            //第一个子节点即为根节点(xml的版本号和字符编码规则)
            XmlNode root =xml.FirstChild.NextSibling;//根节点的下一个节点为skill标签
            XmlNodeList skillList = root.ChildNodes;//获取所有子节点的集合
            //skill为所有技能列表
            foreach (XmlNode skill in skillList) {
                Skill temp=new Skill();
                //nodes为确切技能
                XmlNodeList nodes = skill.ChildNodes;
                //遍历技能信息得到id,name,damage
                foreach (XmlNode node in nodes) {
                    if (node.Name=="id") {
                        string id = node.InnerText;//获取节点内部文本
                        temp.ID =Convert.ToInt32(id);
                    }
                    else if (node.Name == "name") {
                        temp.Name = node.InnerText;
                        //获取文本属性
                        XmlAttributeCollection xac = node.Attributes;
                        //遍历文本的所有属性
                        foreach (XmlAttribute att in xac) {
                            if (att.Name=="lang") {
                                //属性的两种获取方式
                                //1
                                //temp.Lang = att.Value;
                                //2
                                temp.Lang = att.InnerText;
                            }
                        }
                    }
                    else if (node.Name == "damage") {
                        temp.Damage = Convert.ToInt32(node.InnerText);
                    }
                }
                skills.Add(temp);
            }
            foreach (Skill skill in skills) {
                Console.WriteLine(skill.ID+" "+skill.Name+" "+skill.Damage+" "+skill.Lang);
            }
            Console.ReadLine();
        }
    }
}
