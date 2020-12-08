using AllSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.BattleGround;
using static ConsoleApp12.SanGuo;

namespace ConsoleApp12
{
    public abstract class Charactor : Skills
    {
        public Charactor(string name, int attack, int defend, int intelligence, int speed, int man)
        {
            this.Attack = attack;
            this.Defend = defend;
            this.Intelligence = intelligence;
            this.Speed = speed;
            this.Name = name;
            this.Man = man;
            //this.Skills = skills;
        }

        private string name;
        private int attack;
        private int defend;
        private int intelligence;
        private int speed;
        private int man;
        private int woundman = 0;

        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defend { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }
        public int Man { get; set; } = 10000;

        public int WoundMan
        {
            get { return woundman; }
            set
            {
                woundman = value > 0 ? value : 0;
            }
        }
        public abstract int Skill1(Charactor a, Charactor b); //SkillType skillType);
        public abstract int Skill2(Charactor a, Charactor b);
        public abstract int Skill3(Charactor a, Charactor b);
        public virtual int PhysicalAttack(Charactor a, Charactor b)
        {
            int result = (int)Math.Round(((a.Attack - b.Defend) * 1.2 + a.Man / 20) * GenerateRandomNumsForDamage());
            Console.WriteLine("{0}发动普通攻击,{1}受到{2}点伤害 ({3})", a.Name, b.Name, result, b.Man -= result);
            return result;
        }
        //public abstract int Skill4(Skills skills)
    }

    public class Caocao : Charactor
    {
        public Caocao(string name, int attack, int defend, int intelligence, int speed, int man) : base(name, attack, defend, intelligence, speed, man)
        { }

        public override int Skill1(Charactor a, Charactor b)
        {
            //int lanuch = GenerateRandomNums();
            //if (lanuch < 5)
            //{
            //    int damage = Battle.PhysicalAttack(a.Attack, b.Defend);
            //    Console.WriteLine("{0}发动横扫千军，{1}由于横扫千军的伤害，损失了兵力{2}", a.Name, b.Name, damage);
            //    return damage;
            //}
            return 0;
        }
        public override int Skill2(Charactor a, Charactor b)
        {
            //int lanuch = GenerateRandomNums();
            //if (lanuch < 3)
            //{
            //    Console.WriteLine("{0}发动破阵催坚，{1}由于破阵催坚的伤害，损失了兵力600", a.Name, b.Name);
            //    return 600;
            //}
            return 0;
        }
        public override int Skill3(Charactor a, Charactor b)
        {
            QingYongFeiYan qingYongFeiYan = new QingYongFeiYan();
            return qingYongFeiYan.Damage(a, b);
        }
    }

    public class ZhaoYun : Charactor
    {
        public ZhaoYun(string name, int attack, int defend, int intelligence, int speed, int man) : base(name, attack, defend, intelligence, speed, man)
        {

        }

        public override int Skill1(Charactor a, Charactor b)//SkillType skillType)
        {
            //SkillType.Negative
            a.Attack += 40;
            Console.WriteLine("赵云发动一身是胆,攻击力提升40 ({0})", Attack);
            a.Defend += 40;
            Console.WriteLine("赵云发动一身是胆,防御力提升40({0})", Defend);
            a.Intelligence += 40;
            Console.WriteLine("赵云发动一身是胆,智力提升40({0})", Intelligence);
            a.Speed += 40;
            Console.WriteLine("赵云发动一身是胆,速度提升40({0})", Speed);
            return 0;
        }

        public override int Skill2(Charactor a, Charactor b)
        {
            PoZhenCuiJian poZhenCuiJian = new PoZhenCuiJian();
            return poZhenCuiJian.Damage(a, b);
        }
        public override int Skill3(Charactor a, Charactor b)
        {
            HengSaoQianJun hengSaoQianJun = new HengSaoQianJun();
            return hengSaoQianJun.Damage(a, b);
        }

    }

    public enum SkillType
    {
        Positive,
        Negative,
        Strike,
        Command,
        Arms,
        Formation,
    }
}
