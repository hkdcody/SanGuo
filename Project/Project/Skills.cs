using ConsoleApp12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AllSkills
{
    public class Skills
    {
        public class HengSaoQianJun
        {
            public HengSaoQianJun(Charactor A)
            {
                A.Attack += 50;
            }
        }

        public interface IDamageSkills : IPeopleAffected
        {
            public int Damage { get; set; }
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
            OnePeople,
            TwoProple,
            ThreePeople,
        }

    }
}
