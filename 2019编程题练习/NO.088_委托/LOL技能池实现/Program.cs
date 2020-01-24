using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL技能池实现 {
    //设计一个技能池,存放所有的技能
    public static class Skills {
        public static void DematheaJustice() {
            Console.WriteLine("Galen released Demathea justice !");
        }
        public static void NoxasGuillotine() {
            Console.WriteLine("Darius released Noxas guillotine !");
        }
        public static void MagicCrystalArrow() {
            Console.WriteLine("Aich released Magic crystal arrow !");
        }
    }
    public delegate void SkillDelegate();
    public class Hero {
        public SkillDelegate R;
    }

    public class Program {
        static void Main(string[] args) {
            Hero Galen=new Hero();
            Galen.R = Skills.DematheaJustice;
            Hero Aich=new Hero();
            Aich.R = Skills.MagicCrystalArrow;
            Hero Darius=new Hero();
            Darius.R = Skills.NoxasGuillotine;
            Galen.R();
            Aich.R();
            Darius.R();
            Console.ReadLine();
        }
    }
}
