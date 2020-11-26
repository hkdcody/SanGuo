using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.SANGUO;

namespace ConsoleApp12
{
    public class Caocao : Charactor
    {
        public Caocao(string name, int attack, int defend, int intelligence, int speed, int man) : base(name, attack, defend, intelligence, speed, man)
        { }

        public override int Skill1(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 5)
            {
                return 200;
            }
            return 0;
        }
        public override int Skill2(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 3)
            {
                return 600;
            }
            return 0;
        }
        public override int Skill3(Charactor a, Charactor b)
        {
            int lanuch = GenerateRandomNums();
            if (lanuch < 1)
            {
                return 600;
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
            return 300;
        }
        public override int Skill2(Charactor a, Charactor b)
        {
            return 500;
        }
        public override int Skill3(Charactor a, Charactor b)
        {
            return 200;
        }
    }
}
