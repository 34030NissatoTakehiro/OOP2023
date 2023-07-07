using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
           
        }

        private void btDayCalc_Click(object sender, EventArgs e) {

            var now = DateTime.Now;
            var dtp = dtpDate.Value;
            var time = now - dtp;


           
            tbMessage.Text = "誕生日から"+time.Days+"日";
        }

        private void btage_Click(object sender, EventArgs e) {
           
            var now = DateTime.Now;
            var dtp = dtpDate.Value;
            var age = now.Year - dtp.Year;
            if (now < dtp.AddYears(age)) {
                age--;
            }
            tbMessage.Text = "年齢"+age+"歳";
        }

        private void Form1_Load(object sender, EventArgs e) {
            var now = DateTime.Now;
            tbTimeNow.Text = "" + now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
            tmTimeDisp.Start();//タイまースタート
        }

        //タイマーイベントハンドラ
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTimeNow.Text = "" + DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
        }
    }
}
