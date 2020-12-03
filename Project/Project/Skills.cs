using ConsoleApp12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.SanGuo;

namespace AllSkills
{
    public class Skills
    {
        public class HengSaoQianJun : DamageSkills
        {
            public override int DamageCalculator(Charactor A, Charactor B)
            {
                //double deviation = GenerateRandomNumsForDamage();
                int result = (int)Math.Round(((A.Attack - B.Defend) * 1.5 + A.Man / 20) * GenerateRandomNumsForDamage());
                return result;
            }
            //readonly People peoplenumber = People.OnePeople;
            public override int Damage(Charactor A, Charactor B)
            {
                if (SkillLanuch(40) == true)
                {
                    int damage = DamageCalculator(A, B);
                    Console.WriteLine("{0}发动横扫千军,{1}受到{2}点伤害 ({3})", A.Name, B.Name, damage, B.Man -= damage);
                    return damage;
                }
                return 0;
            }

        }

        public class PoZhenCuiJian : DamageSkills
        {
            public override int DamageCalculator(Charactor A, Charactor B)
            {
                B.Defend -= 80 > 0 ? B.Defend : 0;
                //double deviation = GenerateRandomNumsForDamage();
                int result = (int)Math.Round(((A.Attack - B.Defend) * 1.5 + A.Man / 20) * 1.58 * GenerateRandomNumsForDamage());
                return result;
            }
            //readonly People peoplenumber = People.OnePeople;
            public override int Damage(Charactor A, Charactor B)
            {
                if (SkillLanuch(35) == true)
                {
                    int damage = DamageCalculator(A, B);
                    Console.WriteLine("{0}发动破阵催坚,{1}受到{2}点伤害 ({3})", A.Name, B.Name, damage, B.Man -= damage);
                    return damage;
                }
                return 0;
            }
        }

        public class QingYongFeiYan : DamageSkills
        {
            public override int DamageCalculator(Charactor A, Charactor B)
            {
                int result = (int)Math.Round(((A.Attack - B.Defend) * 1.5 + A.Man / 20) * 0.84 * GenerateRandomNumsForDamage());
                return result;
            }
            public override int Damage(Charactor A, Charactor B)
            {

                if (SkillLanuch(40) == true)
                {
                    int damage = DamageCalculator(A, B);
                    Console.WriteLine("{0}发动轻勇飞燕,{1}受到{2}点伤害 ({3})", A.Name, B.Name, damage, B.Man -= damage);
                    return damage;
                }
                return 0;
            }

        }

        public class GuaGuLiaoDu : HealSkills
        {
            public override int HealCalculator(Charactor A, Charactor B)
            {
                int healMan = (int)Math.Round((A.Intelligence * 1.2 + A.Man / 20) * GenerateRandomNumsForDamage());
                healMan = Math.Clamp(A.WoundMan, 0, healMan);
                return healMan;
            }

            public override int Heal(Charactor A, Charactor B)
            {
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

        public abstract class HealSkills : IPeopleAffected
        {
            public virtual People peoplenumber { get; set; }
            public virtual int Heal(Charactor A)
            { return 0; }

            public virtual int Heal(Charactor A, Charactor B)
            { return 0; }

            public virtual int Heal(Charactor A, Charactor B, Charactor C)
            { return 0; }

            public virtual int Heal(Charactor A, Charactor B, Charactor C, Charactor D)
            { return 0; }

            public abstract int HealCalculator(Charactor A, Charactor B);
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
            if (GenerateRandomNums(1, 100) <= lanuchPercentage)
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
            nums += 1;
            return nums;
        }
    }
}
