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
                if (a.Speed > a.Speed) //a first
                {
                    skillAttack(a, b);
                    b.Man -= Damage;
                    physicalAttack(a.Attack, b.Defend);
                    b.Man -= Damage;
                }

                if (a.Speed < b.Speed) //b first
                {
                    skillAttack(b, a);
                    a.Man -= Damage;
                    physicalAttack(b.Attack, a.Defend);
                    a.Man -= Damage;
                }

                if (a.Speed == b.Speed && GenerateRandomNums() > 5) //a first
                {
                    skillAttack(a, b);
                    b.Man -= Damage;
                    physicalAttack(a.Attack, b.Defend);
                    b.Man -= Damage;
                }

                if (a.Speed == b.Speed && GenerateRandomNums() < 5) //b first
                {
                    skillAttack(b, a);
                    a.Man -= Damage;
                    physicalAttack(b.Attack, a.Defend);
                    a.Man -= Damage;
                }
            }

            public int skillAttack(Charactor a, Charactor b)
            {
                Damage = 0;
                Damage += a.Skill1(a, b);
                Damage += a.Skill2(a, b);
                Damage += a.Skill3(a, b);
                return Damage;
            }

            public int physicalAttack(int attack, int defend)
            {
                Damage = 0;
                Damage = (attack - defend) * 20;
                return Damage;
            }

          
        }
    }
}
