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

            public static int Round { get; set; } = 1;

            //public int Round { get; set; } = 1;
            public Battle(Charactor a, Charactor b)
            {
                while (Round <= 8)
                {
                    Console.WriteLine("第{0}回合:", Round);
                    if (a.Speed > a.Speed || (a.Speed == b.Speed && GenerateRandomNums(1, 100) > 50))
                    {
                        Console.WriteLine("{0}先攻!",a.Name);
                        Attack(a, b); //a first
                        Attack(b, a); 
                    }

                    if (a.Speed < b.Speed || (a.Speed == b.Speed && GenerateRandomNums(1, 100) < 50))
                    {
                        Console.WriteLine("{0}先攻!", b.Name);
                        Attack(b, a);  //b first
                        Attack(a, b);
                    }

                    int deadMan = a.WoundMan - (int)(a.WoundMan * 0.9);
                    a.WoundMan = (int)(a.WoundMan * 0.9);                    
                    Console.WriteLine("{0}本回合伤兵数{1},死亡{2}", a.Name, a.WoundMan, deadMan);

                    deadMan = b.WoundMan - (int)(b.WoundMan * 0.9);
                    b.WoundMan = (int)(b.WoundMan * 0.9);
                    Console.WriteLine("{0}本回合伤兵数{1},死亡{2}", b.Name, b.WoundMan, deadMan);
                    Round++;
                }
            }


            public void Attack(Charactor a, Charactor b)
            {
                b.WoundMan = SkillAttack(a, b);

                b.WoundMan += a.PhysicalAttack(a, b);
            }
            public int SkillAttack(Charactor a, Charactor b)
            {
                Damage = a.Skill1(a, b);
                b.WoundMan += Damage;
                Damage += a.Skill2(a, b);
                b.WoundMan = Damage;
                Damage += a.Skill3(a, b);
                b.WoundMan = Damage;
                return Damage;
            }




            public int PhysicalAttack(Charactor a, Charactor b)
            {
                Damage = (a.Attack - b.Defend) * 20;
                b.WoundMan += Damage;
                return Damage;
            }
        }
    }
}
