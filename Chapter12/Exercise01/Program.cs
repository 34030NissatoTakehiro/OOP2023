using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
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
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            //設定ファイルのシリアル化
            var emp = new Employee {
                Id = 00011,
                Name = "Hirasawa Akihisa",
                HireDate =new DateTime(1994,5,25)
            };
            using (var write = XmlWriter.Create("employee.xml")) {
                var serialize = new XmlSerializer(emp.GetType());
                serialize.Serialize(write, emp);
            }
            using (var reder = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employ = serializer.Deserialize(reder) as Employee;
                Console.WriteLine(employ);
            }

        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 0002,
                    Name = "松島航大",
                      HireDate =new DateTime(2003,5,25)
                },
                 new Employee {
                    Id = 0003,
                    Name = "鷹野圧",
                      HireDate =new DateTime(2003,5,25)
                }
            };
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "",
            };
            using (var write = XmlWriter.Create(v, settings)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(write, emps);
            }
        
        }

        private static void Exercise1_3(string v) {
            using (XmlReader reader = XmlReader.Create(v)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
               var emps= serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps) {
                    Console.WriteLine("{0},{1},{2}", emp.Id, emp.Name, emp.HireDate);
                }
            }

        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 0002,
                    Name = "松島航大",
                      HireDate =new DateTime(2003,5,25)
                },
                 new Employee {
                    Id = 0003,
                    Name = "鷹野圧",
                      HireDate =new DateTime(2003,5,25)
                }
            };
            using (var stream = new FileStream(v,FileMode.Create,FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(emps.GetType());

            }

        }
    }
    [DataContract]
    public class Employee2 {
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember (Name = "hireDate")]
        public DateTime HireDate { get; set; }
    }
}
