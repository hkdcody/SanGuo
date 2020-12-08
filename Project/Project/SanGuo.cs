using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.BattleGround;

namespace ConsoleApp12
{
    public class SanGuo
    {
        public static int GenerateRandomNums(int start , int end)
        {
            Random possibility = new Random();
            int lanuch = possibility.Next(start, ++end); //both start and end will be include in this method
            return lanuch;
        }

       

        static void Main(string[] args)
        {
            Charactor caoCao = new Caocao("曹操", 137, 233, 226, 117, 10000);
            Charactor zhaoYun = new ZhaoYun("赵云", 280, 212, 132, 157, 10000);
            Battle BattleGround = new Battle(caoCao, zhaoYun);

        }
    }
}
