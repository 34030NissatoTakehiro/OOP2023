using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://www.msn.com/ja-jp/news/entertainment/%E3%83%86%E3%83%AC%E3%83%93%E6%9C%9D%E6%97%A5-%E6%9E%97%E7%BE%8E%E6%B2%99%E5%B8%8C%E3%82%A2%E3%83%8A%E3%81%8C%E4%B8%80%E6%97%A5%E7%BD%B2%E9%95%B7-%E8%87%AA%E8%BB%A2%E8%BB%8A%E3%83%98%E3%83%AB%E3%83%A1%E3%83%83%E3%83%88-%E5%91%BD%E3%82%92%E5%AE%88%E3%82%8B%E3%81%9F%E3%82%81%E3%81%AB%E3%82%82%E7%9D%80%E7%94%A8%E3%82%92/ar-AA1haZJJ?ocid=winp2fptaskbarent&cvid=a09fe5a78d4c4938e5032c2803e4f215&ei=5");
               Console.WriteLine(html);
                }
    }
}
