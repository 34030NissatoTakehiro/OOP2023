using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var subject= new List<Student>();//点数を格納する
            var lines = File.ReadAllLines(filePath);//ファイルから全データ呼び込む

            foreach (string line in lines) {//すべての行から1行ずつ取り出す
                var items = line.Split(',');//区切りで項目別に分ける
                var syukei = new Student {//syukeiインスタンスの生成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2]),

                };
                subject.Add(syukei);//syukeiインスタンスをコレクションに追加
            }


            return subject;






        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new SortedDictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score;

                } else {
                    dict[student.Subject] = student.Score;
                }
            }

            return dict;





        }
    }
}
