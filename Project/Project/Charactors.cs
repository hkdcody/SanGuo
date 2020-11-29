using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.SanGuo;

namespace ConsoleApp12
{
    public abstract class Charactor
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

        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defend { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }
        public int Man { get; set; }
        public abstract int Skill1(Charactor a, Charactor b);
        public abstract int Skill2(Charactor a, Charactor b);
        public abstract int Skill3(Charactor a, Charactor b);
    }

    public class Caocao : Charactor
    {
        public Caocao(string name, int attack, int defend, int intelligence, int speed, int man) : base(name, attack, defend, intelligence, speed, man)
        { }

        public override int Skill1(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 5)
            {
                Console.WriteLine("{0}发动横扫千军，{1}由于横扫千军的伤害，损失了兵力200", a.Name, b.Name);
                return 200;
            }
            return 0;
        }
        public override int Skill2(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 3)
            {
                Console.WriteLine("{0}发动破阵催坚，{1}由于破阵催坚的伤害，损失了兵力600", a.Name, b.Name);
                return 600;
            }
            return 0;
        }
        public override int Skill3(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 1)
            {
                Console.WriteLine("{0}发动所向披靡，{1}由于所向披靡的伤害，损失了兵力800", a.Name, b.Name);
                return 800;
            }
            return 0;
        }
    }

    public class ZhaoYun : Charactor
    {
        public ZhaoYun(string name, int attack, int defend, int intelligence, int speed, int man) : base(name, attack, defend, intelligence, speed, man)
        { }

        public override int Skill1(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 5)
            {
                Console.WriteLine("{0}发动机型军略，{1}由于机型军略的伤害，损失了兵力200", a.Name, b.Name);
                return 200;
            }
            return 0;
        }
        public override int Skill2(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 3)
            {
                Console.WriteLine("{0}发动八门金锁，{1}由于八门金锁的伤害，损失了兵力400", a.Name, b.Name);
                return 400;
            }
            return 0;
        }
        public override int Skill3(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 1)
            {
                Console.WriteLine("{0}发动神机妙算，{1}由于神机妙算的伤害，损失了兵力600", a.Name, b.Name);
                return 600;
            }
            return 0;
        }
    }
}
