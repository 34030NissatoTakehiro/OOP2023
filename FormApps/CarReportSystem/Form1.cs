using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();


        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }
        //追加ボタン　クリック時イベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport car = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Report = tbReport.Text,
                CarName = cbCarName.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(car);
       



        }
        private CarReport.MakerGroup getSelectMaker() {

            return CarReport.MakerGroup.トヨタ;
          
        }
    }
}
