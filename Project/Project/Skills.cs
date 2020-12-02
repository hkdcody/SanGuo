using ConsoleApp12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AllSkills
{
    public class Skills
    {
        public class HengSaoQianJun : DamageSkills
        {
            public override int DamageCalculator(Charactor A, Charactor B)
            {
                double deviation = GenerateRandomNumsForDamage();
                int result = (int)Math.Round(((A.Attack - B.Defend) * 1.5 + A.Man / 20) * (1 + deviation));
                return result;
            }
            //readonly People peoplenumber = People.OnePeople;
            public override int Damage(Charactor A, Charactor B)
            {
                int damage = DamageCalculator(A, B);
                Console.WriteLine("{0}发动横扫千军,{1}受到{2}点伤害 ({3})", A.Name, B.Name, damage, B.Man -= damage);
                return damage;
            }

        }

        public class PoZhenCuiJian : DamageSkills
        {
            public override int DamageCalculator(Charactor A, Charactor B)
            {
                B.Defend -= 80;
                int result = (int)Math.Round(((A.Attack - B.Defend) * 1.5 + A.Man / 20) * 1.58 * GenerateRandomNumsForDamage());
                return result;
            }
            //readonly People peoplenumber = People.OnePeople;
            public override int Damage(Charactor A, Charactor B)
            {
                if (SkillLanuch(35) == true)
                {
                    int damage = DamageCalculator(A, B);
                    Console.WriteLine($"{0}发动破阵催坚,{1}受到{3}点伤害 ({4})", A.Name, B.Name, damage, B.Man -= damage);
                    return damage;
                }

                return 0;
            }
        }



        public abstract class DamageSkills : IPeopleAffected
        {
            public virtual People peoplenumber { get; set; }

            public virtual int Damage(Charactor A, Charactor B)
            { return 0; }

            public virtual int Damage(Charactor A, Charactor B, Charactor C)
            { return 0; }

            public virtual int Damage(Charactor A, Charactor B, Charactor C, Charactor D)
            { return 0; }

            public abstract int DamageCalculator(Charactor A, Charactor B);
        }



        public interface IHealSkillsa
        {


        }

        public interface IPeopleAffected
        {
            public People peoplenumber { get; set; }
        }

        public enum People
        {
            OnePeople = 1,
            TwoProple = 2,
            ThreePeople = 3,
        }

        public static bool SkillLanuch(int lanuchPercentage)
        {
            if (SanGuo.GenerateRandomNums() <= lanuchPercentage)
            {
                return true;
            }

            return false;
        }

        public static double GenerateRandomNumsForDamage()
        {
            Random possibility = new Random();
            double nums = possibility.NextDouble() / 10;  //range (0- 0.1)
            nums -= 0.05; //range (-0.05 --0.05)
            nums = Math.Round(nums, 4);  //保留5位有效数字
            return nums;
        }
    }
}
