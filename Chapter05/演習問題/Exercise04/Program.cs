using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
#elif StringArray
            Stopwatch sw = new Stopwatch();//大麻インスタンス生成
            sw.Start();

            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
#endif



#if NonArray
            var lines = line.Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born","誕生年").Split(';');



            //foreach (var s in line.Split(';')) {
            //    var array = s.Split('=');
            //    Console.WriteLine("{0}:{1}",Tojapanese(array[0]),array[1]);
            //}
            foreach (var s in lines) {
                Console.WriteLine(s);

            }
#elif StringArray
            for (int i = 0; i < lines.Length; i++) {
                var moji = lines[i].Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born", "誕生年").Replace("=",":").Split(';');
                Console.WriteLine(" ");

                foreach (var s in moji) {
                    Console.WriteLine(s);
                 
                }

            }
        
            Console.WriteLine("anese実行時間 = {0}", sw.Elapsed.ToString(@"ss\.fffff"));//時間表示

#endif


        }

         //static int Tojapanese(string v) {
            //switch (key) {
            //    case "Novelist":
            //        return "作家";
            //    case "BestWork":
            //        return "代表作";
            //    case "Born":
            //        return "誕生年";
            //    default:
            //        return "引数エラー";
            //}
            //throw new ArgumentException("正しい引数ではありません");
      //  }
      //  }

    }
}