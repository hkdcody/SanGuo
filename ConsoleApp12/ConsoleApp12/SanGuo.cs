﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static ConsoleApp12.BattleGround;

namespace ConsoleApp12
{
    public class SanGuo
    {       
        public static int GenerateRandomNums()
        {
            Random possibility = new Random();
            int lanuch = possibility.Next(1, 10);
            return lanuch;
        }
  
        static void Main(string[] args)
        {
            Charactor caoCao = new Caocao("曹操", 137, 233, 226, 117, 10000);
            Charactor zhaoYun = new ZhaoYun("赵云", 280, 212, 132, 157, 10000);

            Battle BattleGround = new Battle(caoCao, zhaoYun);
            Console.WriteLine(caoCao.Man);
            Console.WriteLine(caoCao.Name);
            Console.WriteLine(zhaoYun.Man);
        }
    }
}