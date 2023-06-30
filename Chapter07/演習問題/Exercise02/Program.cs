
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbrs = new Abbreviations();
            //addメソットの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");


            //7.2.3
            //上のaddメソットで2つのオブジェクトを追加して読み込む
            int count = abbrs.Count;
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            //7.2.3(Removeの呼び出し)
            if (abbrs.Remove("NPT")) 
                Console.WriteLine(abbrs.Count);
            if (!abbrs.Remove("NPT"))
                Console.WriteLine("削除できませんでした。");
            Console.WriteLine();


            //7.2.4
            //IEnumerable実装したのでLINQが使える
          var threewords=   abbrs.Where(abb => abb.Key.Length == 3);
            foreach (var u in threewords) {
                Console.WriteLine("{0}={1}",u.Key, u.Value);
            }
;          
        }
    }
}
