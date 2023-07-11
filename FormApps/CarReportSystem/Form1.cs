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
                CarImage= pbCarImage.Image,
                Maker = getSelectMaker(),
               
            };
            CarReports.Add(car);


        }
        private CarReport.MakerGroup getSelectMaker() {
            //int tag = 0;
            //foreach (var item in gbMaker.Controls) {
            //    if (((RadioButton)item).Checked) {
            //        return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                    
            //    }
                
            //}
           

           if (rbToyota.Checked) {
               return CarReport.MakerGroup.トヨタ;
            } else if (rbNissan.Checked) {
               return CarReport.MakerGroup.日産;
           } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            } else if (rbSubaru.Checked) {
              return CarReport.MakerGroup.スバル;
            } else if (rbSuzuki.Checked) {
                return CarReport.MakerGroup.スズキ;
            } else if (rbDaihatsu.Checked) {
                return CarReport.MakerGroup.ダイハツ;

            } else if (rbImported.Checked) {
                return CarReport.MakerGroup.輸入車;
            }
            return CarReport.MakerGroup.その他;



        }
        private void setSelectedMaker(CarReport.MakerGroup maker) {
            switch (maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                default:
                    break;
            }

        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdimageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdimageFileOpen.FileName);
        }

      

        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;
        }


        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dgvCarReports.Columns[5].Visible = false;

            dtpDate.Text = dgvCarReports.CurrentRow.Cells[0].Value.ToString();
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getSelectMaker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text; 
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;          
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;


        }

      
    }
}
