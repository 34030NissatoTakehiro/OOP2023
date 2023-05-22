using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class SalesCounter {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales( filePath);
        }
        //店舗別売上求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount;

                } else {
                    dict[sale.ShopName] = sale.Amount;
                }
            }

            return dict;
        }
        //カテゴリー別売上求める
        public IDictionary<string, int> GetPerProductCategory() {
           var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory)) {
                    dict[sale.ProductCategory] += sale.Amount;

                } else {
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }

            return dict;
        }
       
        private  IEnumerable<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();//売上データを格納する
            var lines = File.ReadAllLines(filePath);//ファイルから全データ呼び込む

            foreach (string line in lines) {//すべての行から1行ずつ取り出す
                var items = line.Split(',');//区切りで項目別に分ける
                var sale = new Sale {//saleインスタンスの生成
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),

                };
                sales.Add(sale);//Saleインスタンスをコレクションに追加
            }


            return sales;
        }


    }
}
