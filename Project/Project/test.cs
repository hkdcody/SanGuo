using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp12
{
    class MartialArtsMaster
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>     
        /// /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 门派
        /// </summary>
        public string Menpai { get; set; }
        /// <summary>
        /// 武学
        /// </summary>
        public string Kungfu { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public int Level { get; set; }
    }

    class Kongfu
    {
        /// <summary>
        /// 武学编号
        /// </summary>
        public int KongfuId { get; set; }

        /// <summary>
        /// 武学名称
        /// </summary>
        public string KongfuName { get; set; }

        /// <summary>
        /// 杀伤力
        /// </summary>
        public int Lethality { get; set; }
    }
    public class A
    {
        //static void Main(string[] args)
        //{
        //    var master = new List<MartialArtsMaster>(){
        //        new MartialArtsMaster(){ Id = 1, Name = "a黄蓉",    Age = 18, Menpai = "丐帮", Kungfu = "打狗棒法",  Level = 9  },
        //        new MartialArtsMaster(){ Id = 2, Name = "b洪七公",  Age = 70, Menpai = "丐帮", Kungfu = "打狗棒法",  Level = 10 },
        //        new MartialArtsMaster(){ Id = 3, Name = "c郭靖",    Age = 22, Menpai = "丐帮", Kungfu = "降龙十八掌",Level = 10 },
        //        new MartialArtsMaster(){ Id = 4, Name = "d任我行",  Age = 50, Menpai = "明教", Kungfu = "葵花宝典",  Level = 1  },
        //        new MartialArtsMaster(){ Id = 5, Name = "e东方不败",Age = 35, Menpai = "明教", Kungfu = "葵花宝典",  Level = 10 },
        //        new MartialArtsMaster(){ Id = 6, Name = "f林平之",  Age = 23, Menpai = "华山", Kungfu = "葵花宝典",  Level = 7  },
        //        new MartialArtsMaster(){ Id = 7, Name = "g岳不群",  Age = 50, Menpai = "华山", Kungfu = "葵花宝典",  Level = 8  }
        //    };
        //    var kongfu = new List<Kongfu>(){
        //        new Kongfu(){KongfuId=1, KongfuName="打狗棒法", Lethality=90},
        //        new Kongfu(){KongfuId=2, KongfuName="降龙十八掌", Lethality=95},
        //        new Kongfu(){KongfuId=3, KongfuName="葵花宝典", Lethality=100}
        //    };

            ////query 写法
            //var GaiBangMaster = from m in master
            //                    where m.Level >= 8 && m.Menpai == "丐帮"
            //                    select m;
            //foreach (var m in GaiBangMaster)
            //{
            //    Console.WriteLine(m.Name);
            //}

            ////fluent 写法
            //GaiBangMaster = master.Where(m => m.Level >= 8 && m.Menpai == "丐帮");

            //foreach (var m in GaiBangMaster)
            //{
            //    Console.WriteLine(m.Name);
            //}


            ////过滤武功杀伤大于95 query
            //var Lethalmaster = from m in master
            //                   from n in kongfu
            //                   where n.Lethality >= 95 && m.Kungfu == n.KongfuName
            //                   orderby m.Level
            //                   select m;
            //foreach (var m in Lethalmaster)
            //{
            //    Console.WriteLine(m.Name);
            //}

            //fluent
            //var Lethalmaster3 = master.Select(m => m.Level >= 8 && m.Menpai == "丐帮");
            //foreach (var m in Lethalmaster3)
            //{
            //    Console.WriteLine(m.ToString());
            //}


            ////var Lethalmaster3 = master.SelectMany(m=>m.Name).Where(n=>n)
            ////var Lethalmaster2 = master.SelectMany(m => m.Level >= 8 && m.Menpai == "丐帮");
            //var masterKongfuMethod = master.SelectMany(k => kongfu, (m, k) => new { mt = m, kf = k })
            //                               .Where(x => x.kf.Lethality > 90 && x.mt.Kungfu == x.kf.KongfuName)
            //                               .OrderBy(m => m.mt.Level)
            //                               .Select(m => m.mt.Id + "  " + m.mt.Name + "  " + m.mt.Age + "  " + m.mt.Menpai + "  " + m.mt.Kungfu + "  " + m.mt.Level + "  ");
        //}
    }

    //class cicle : shope
    //{
    //    public double arca(double r) //这个是重载，无须override
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public override double arca() // 无参数函数必须重写
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
