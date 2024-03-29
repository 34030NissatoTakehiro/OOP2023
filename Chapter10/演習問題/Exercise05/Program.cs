﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise05 {
    class Program {
        static void Main(string[] args) {
            TagLower("sample.html");

            // これ以降は確認用
            var text = File.ReadAllText("sample.html");
            Console.WriteLine(text);
        }

        private static void TagLower(string file) {
            var lines = File.ReadLines(file);
            var sb = new StringBuilder();
            foreach (var item in lines) {
                
                var ss =  Regex.Replace(item, @"<(/?)([A-Z][A-Z0-9]*)(.*?)>",//正規表現
                                                        m=> {
                                                            return string.Format("<{0}{1}{2}>",
                                                          m.Groups[1].Value, m.Groups[2].Value.ToLower(), m.Groups[3].Value);
                                                             }
                                                        );
                sb.AppendLine(ss);
            }

            //ファイル出力
            File.WriteAllText(file, sb.ToString());

        }
    }
}
