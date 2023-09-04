using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program  {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            //設定ファイルのシリアル化
            var emp = new Employee {
                Id = 00011,
                Name = "Hirasawa Akihisa",
                HireDate = DateTime.Now,
            };
            using (var write = XmlWriter.Create("employee.xml")) {
                var seriarize = new XmlSerializer(emp.GetType());
                seriarize.Serialize(write, emp);
            }

        }

        private static void Exercise1_2(string v) {
        
        
        }

        private static void Exercise1_3(string v) {
        
        
        }

        private static void Exercise1_4(string v) {
        
        
        }
    }
}
