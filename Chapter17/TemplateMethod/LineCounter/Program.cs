using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    class Program {
        static void Main(string[] args) {
            TextProcessor.Run<LineCounterProssecor>(@"C:\Users\infosys\Desktop\カーレポート実装手順書.txt");
        }
    }
}
