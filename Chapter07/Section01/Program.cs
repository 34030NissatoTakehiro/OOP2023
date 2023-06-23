using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
#if false
var flowerdict = new Dictionary<string, int>() {
            ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahila"] = 450,
            };
           
            //あさがおの追加
            flowerdict["moning glory"] = 250;

            Console.WriteLine("ひまわりの価格は{0}円です。",flowerdict["sunflower"]);
            Console.WriteLine("チューリップの価格は{0}円です。", flowerdict["tulip"]);
            Console.WriteLine("あさがおの価格は{0}円です。", flowerdict["moning glory"]);
#endif
            //辞書に登録
            Console.WriteLine("県庁所在地の登録");
            var citys
               = new Dictionary<string, Cityinfo>();


            Console.Write("県；");
            string pref = Console.ReadLine();


            while (pref != "999") {
                var cityinfo = new Cityinfo();


                Console.Write("県庁所在地；");
                cityinfo.City = Console.ReadLine();

                Console.Write("人口;");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (citys.ContainsKey(pref)) {
                    Console.WriteLine("既に登録してあります。　　上書き：Y 上書きなし：N");
                    var hantei = Console.ReadLine();
                    if (hantei == "Y") {
                        citys[pref] =cityinfo;
                    }
                } else {

                    citys.Add(pref, cityinfo);

                }
 
                Console.Write("県；");
                pref = Console.ReadLine();

            }
            Console.WriteLine("1.一覧表示  2.県名指定");
            var select = Console.ReadLine();
            if (select =="1") {
                var kouzyunn = citys.OrderByDescending(x=> x.Value.Population);
                foreach (var item in kouzyunn) {
                   
                    Console.WriteLine("{0}【{1}(人口:{2})】", item.Key, item.Value.City,item.Value.Population);
                     
                }
            }
            else{
                Console.WriteLine("県名を入力");
                var ken = Console.ReadLine();
                Console.WriteLine(citys[ken].City + citys[ken].Population);

            }
           

        }
        
    }
    class Cityinfo {
      

      

       public string City { get; set; }//都市
       public  int Population { get; set; }//人口

       

    }
}
