using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp12
{
    public class SANGUO
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

        public static int GenerateRandomNums()
        {
            Random possibility = new Random();
            int lanuch = possibility.Next(1, 10);
            return lanuch;
        }

        public class Battle
        {
            public int Damage { get; set; }

            //public int Round { get; set; } = 1;
            public Battle(Charactor A, Charactor B)
            {
                if (A.Speed > B.Speed)
                {

                    physicalAttack(A.Attack, B.Defend);
                    B.Man = CauseDamage(B.Man, Damage);
                }

                else if (A.Speed < B.Speed)
                {
                    physicalAttack(B.Attack, A.Defend);
                    A.Man = CauseDamage(A.Man, Damage);
                }

                else
                {
                    Random whoAttackFirst = new Random();
                    int receive = whoAttackFirst.Next(0, 1);
                    if (receive == 0)
                    {
                        physicalAttack(A.Attack, B.Defend);
                        B.Man = CauseDamage(A.Man, Damage);
                    }
                    else
                    {
                        physicalAttack(B.Attack, A.Defend);
                        A.Man = CauseDamage(A.Man, Damage);
                    }

                }

                //Round++;
            }



            public int physicalAttack(int attack, int defend)
            {
                Damage = (attack - defend) * 20;
                return Damage;
            }

            public int CauseDamage(int man, int damage)
            {
                man -= damage;
                return man;
            }
        }
        static void Main(string[] args)
        {
            //List<Charactor> charactors = new List<Charactor>() { new Charactor("Caocao", 22, 32, 32, 12,9000), new Charactor("Zhugeliang", 21, 32, 123, 323,9000) };
            //charactors.Add(new Charactor(12,32,23,11));
            //Charactor Caocao = new Charactor("Caocao", 40, 32, 32, 12, 9000, new List<Skills>() { });
            //Charactor Zhugeliang = new Charactor("Zhugeliang", 21, 32, 123, 10, 9000, new List<Skills>() { });
            //Battle BattleGround = new Battle(Caocao, Zhugeliang);

            Charactor caoCao = new Caocao("Caocao", 137, 233, 226, 117, 10000);
            Charactor zhaoYun = new ZhaoYun("Zhaoyun", 280, 212, 132, 157, 10000);
            
            Battle BattleGround = new Battle(caoCao, zhaoYun);
            Console.WriteLine(caoCao.Man);
            Console.WriteLine(zhaoYun.Man);
        }
    }
}
