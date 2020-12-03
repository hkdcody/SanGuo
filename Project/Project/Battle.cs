using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.SanGuo;

namespace ConsoleApp12
{
    public class BattleGround
    {
        public class Battle
        {
            public int Damage { get; set; }

            //public int Round { get; set; } = 1;
            public Battle(Charactor a, Charactor b)
            {
                if (a.Speed > a.Speed || (a.Speed == b.Speed && GenerateRandomNums(1,100) > 50))
                {
                    WhoAttackFirst(a, b); //a first
                }

                if (a.Speed < b.Speed || (a.Speed == b.Speed && GenerateRandomNums(1,100) < 50))
                {
                    WhoAttackFirst(b, a);  //b first
                }
            }


            public void WhoAttackFirst(Charactor a, Charactor b)
            {
                SkillAttack(a, b);
                b.Man -= Damage;
                a.PhysicalAttack(a, b);
                b.Man -= Damage;

                SkillAttack(b, a);
                a.Man -= Damage;
                b.PhysicalAttack(b, a);
                a.Man -= Damage;
            }
            public int SkillAttack(Charactor a, Charactor b)
            {
                Damage += a.Skill1(a, b);
                b.WoundMan += (int)(Damage * 0.9);
                Damage += a.Skill2(a, b);
                b.WoundMan += (int)(Damage * 0.9);
                Damage += a.Skill3(a, b);
                b.WoundMan += (int)(Damage * 0.9);
                return Damage;
            }











            public static int PhysicalAttack(int attack, int defend)
            {
                int damage = 0;
                damage = (attack - defend) * 20;
                return damage;
            }
        }
    }
}
