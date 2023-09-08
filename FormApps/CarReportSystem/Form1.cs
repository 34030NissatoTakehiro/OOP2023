using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private int size;
        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();
        public Form1() {
            InitializeComponent();
            // dgvCarReports.DataSource = CarReports;
        }
        //ステータスラベルの表示
        private void satasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }


        //追加ボタン　クリック時イベントハンドラー🐒
        private void btAddReport_Click(object sender, EventArgs e) {
            satasLabelDisp();//ステートラベル非表示🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵
            if (cbAuthor.Text.Equals("")) {
                satasLabelDisp("記録者入力しましょう！！！！");
                return;
            } else if (cbCarName.Text.Equals("")) {
                satasLabelDisp("車名を入力しましょう！！！！");
                return;
            } else {
                satasLabelDisp();
            }

            CarReport car = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Report = tbReport.Text,
                CarName = cbCarName.Text,
                CarImage = pbCarImage.Image,
                Maker = getSelectMaker(),
            };
            btAddReport.Enabled = true;
            CarReports.Add(car);
            setCbAuther(cbAuthor.Text);
            Clear();
            dgvCarReports.ClearSelection();
            btDeleteReport.Enabled = false;
            btModifyReport.Enabled = false;
        }
        private void setCbAuther(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private CarReport.MakerGroup getSelectMaker() {
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

        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdimageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdimageFileOpen.FileName);
            }
            ofdimageFileOpen.ShowDialog();
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }

            if (dgvCarReports.Rows.Count == 0) {
                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }

            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;

            Clear();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[6].Visible = false;

            tsInfoText.Text = "";//テキスト初期化
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
            tmTimeUpdate.Start();

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.Yellow;
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;


            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;
            //設定ファイルを逆シリアル化して背景を設定🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
        }

        //レコード選択
        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {


        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text.Equals("")) {
                satasLabelDisp("記録者入力しましょう！！！！");
                return;
            } else if (cbCarName.Text.Equals("")) {
                satasLabelDisp("車名を入力しましょう！！！！");
                return;
            } else {
                satasLabelDisp();
            }
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;


            //if (dgvCarReports.Rows.Count != 0) {/hjg
            //    dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            //    dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            //    dgvCarReports.CurrentRow.Cells[2].Value = getSelectMaker();
            //    dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            //    dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            //    dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
            //}


            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202306DataSet);

            //if (dgvCarReports.Rows.Count != 0) {
            //    dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            //    dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            //    dgvCarReports.CurrentRow.Cells[2].Value = getSelectMaker();
            //    dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            //    dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            //    dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
            //}
        }

        private void Clear() {
            cbAuthor.Text = "";
            cbCarName.Text = "";
            gbMaker.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
            foreach (var item in gbMaker.Controls) {
                ((RadioButton)item).Checked = false;
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();//モーダルダイアログとして表示🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                this.BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }

        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            size = size < 4 ? ((size == 1) ? 3 : ++size) : 0;
            pbCarImage.SizeMode = (PictureBoxSizeMode)size;
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                //設定ファイルのシリアル化
                using (var write = XmlWriter.Create("settings.xml")) {
                    var seriarize = new XmlSerializer(settings.GetType());
                    seriarize.Serialize(write, settings);
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {

                MessageBox.Show("設定ファイル読み込みエラー");
            }
        }

        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdCarRepoSave.ShowDialog() == DialogResult.OK) {
                //バイナリ形式でシリアル化
                var bf = new BinaryFormatter();
                try {
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, CarReports);
                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofbCarRepoOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化バイナリ形式🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵🐵
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofbCarRepoOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;
                        dgvCarReports.Columns[5].Visible = false;
                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();
                        Clear();
                        foreach (var s in CarReports) {
                            setCbAuther(s.Author);
                            setCbCarName(s.CarName);
                        }

                    }

                }
                catch (Exception ex) {


                }
            }
        }


        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (0 < dgvCarReports.RowCount) {

                dgvCarReports.Columns[5].Visible = false;

                dtpDate.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();
                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value) ?
                                    ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;
                //if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)) {
                //    pbCarImage.Image = ByteArrayToImage((byte[])dgvCarReports.CurrentRow.Cells[6].Value);
                //} else {
                //    pbCarImage.Image = null;
                //}


                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
            }
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }


        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202306DataSet);


        }

        //接続ボタンのイベントハンドラー
        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202306DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202306DataSet.CarReportTable);
            dgvCarReports.ClearSelection();//選択解除
        }
    }
}
