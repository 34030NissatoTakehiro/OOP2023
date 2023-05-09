using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    
    class Program {
        static void Main(string[] args) {
            #region P26のサンプル
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daihuku  = new Product(235, "大福", 160);

            //Console.WriteLine("税込価格："+karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込価格：" + daihuku.GetPriceIncludingTax());
            #endregion
            #region　０５０８演習１
            DateTime date = new DateTime(2023, 5, 8);
           

            string result = date.ToString("今日は"+"yyyy年MM月dd日");
            Console.WriteLine(result);

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            DateTime daysbefor10 = date.AddDays(-10);

            

            Console.WriteLine("今日の１０日後は" + daysAfter10.ToString("今日は" + "yyyy年MM月dd日"));
            Console.WriteLine("今日の１０日前は"+ daysbefor10.ToString("今日は" + "yyyy年MM月dd日"));
            #endregion
            #region 誕生日計算
            Console.WriteLine("誕生日を出力");
            Console.Write("西暦：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日；");
            int day = int.Parse(Console.ReadLine());

            DateTime dateToday =  DateTime.Today;
            DateTime birthday = new DateTime(year, month, day);

            TimeSpan afterday = dateToday - birthday;


            Console.WriteLine("誕生日から"+ afterday.Days + "日");
            #endregion

            string dayofweek = birthday.ToString("dddd");
            Console.Write("あなた生まれたのは" + dayofweek);


        }
    }
}
