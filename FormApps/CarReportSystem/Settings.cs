using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    //設定情報
    public class Settings {
        public int MainFormColor { get; set; }
        private static Settings instance;

        //コンストラクタ
        private  Settings() 
            { }
            static public  Settings getInstance() {
                if (instance == null) {
                    instance = new Settings();

                }
            return instance;
            }
        


    }
    
}
