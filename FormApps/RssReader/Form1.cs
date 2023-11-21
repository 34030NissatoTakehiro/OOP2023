using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> ITEMDATA = new List<ItemData>();
        ToolTip ToolTip;
        public Form1() {
            InitializeComponent();
        }

        Dictionary<string, string> OKINIIRIDict = new Dictionary<string, string>();

        Dictionary<string, string> ATOYOMIDict= new Dictionary<string, string>();

        class favoritestation {
            public string Name { set; get; }
            public string URL { set; get; }

            public favoritestation(string URL,string Name) {
                this.Name = Name;
                this.URL = URL;
            }
            public override string ToString() {
                return Name;
                
                
            }
           

            }
        class ATOYOMI {
            public string AtoName { set; get; }
            public string AtoURL { set; get; }

            public ATOYOMI(string AtoURL, string AtoName) {
                this.AtoName = AtoName;
                this.AtoURL = AtoURL;
            }
            public override string ToString() {
                return AtoName;

            }
        }
        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") {
                return;
            }
            lbRssTitle.Items.Clear();
            using (var wc = new WebClient()) {

                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);
                ITEMDATA = xdoc.Root.Descendants("item")
                                      .Select(x => new ItemData {
                                          Title = (string)x.Element("title"),
                                          Link = (string)x.Element("link"),
                                      }).ToList();

                foreach (var node in ITEMDATA) {
                    lbRssTitle.Items.Add(node.Title);

                }
            }





        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            var wb = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ITEMDATA[wb].Link);
            tbAtoName.Text = ITEMDATA[lbRssTitle.SelectedIndex].Title;
            tbAtoURL.Text = ITEMDATA[lbRssTitle.SelectedIndex].Link;
        }

        private void Form1_Resize(object sender, EventArgs e) {
        }

        private void btGopage_Click(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(ITEMDATA[++lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException) {

                return;
            }
            
        }

        private void btBackPage_Click(object sender, EventArgs e) {
            try {
                wbBrowser.Navigate(ITEMDATA[--lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException) {

                return;
            }
        }



        private void tbCartop_CheckedChanged(object sender, EventArgs e) {
           RadioButton("https://news.yahoo.co.jp/rss/media/wcartop/all.xml");
        }

        private void rbMotorsports_CheckedChanged(object sender, EventArgs e) {
           RadioButton("https://news.yahoo.co.jp/rss/media/mmagazine/all.xml");
        }

        private void rbBasketBall_CheckedChanged(object sender, EventArgs e) {
           RadioButton("https://news.yahoo.co.jp/rss/media/nbpvbball/all.xml");
        }

        private void rbIT_CheckedChanged(object sender, EventArgs e) {
            RadioButton( "https://news.yahoo.co.jp/rss/topics/it.xml");
        }

        private void btOKINIIRI_Click(object sender, EventArgs e) {
            favoritestation OKINIIRI = new favoritestation(tbURLBOX.Text, tbOkiniName.Text);
            if (tbOkiniName.Text.Equals("") || tbURLBOX.Text.Equals("")) {
                lbinfomation.Text = "未入力では登録されません。";
            } else {



                if (OKINIIRIDict.ContainsKey(tbURLBOX.Text) || OKINIIRIDict.ContainsValue(tbOkiniName.Text)) {
                    lbinfomation.Text = "既に登録されています";


                } else {
                   
                        lbinfomation.Text = " ";
                        OKINIIRIDict.Add(tbURLBOX.Text, tbOkiniName.Text);
                        cbOkiniName.Items.Add(OKINIIRI);

                        tbURLBOX.Clear();
                        tbOkiniName.Clear();
                    



                }
            }
        }

        private void cbOkiniName_SelectedIndexChanged(object sender, EventArgs e) {
            
            favoritestation favorite =(favoritestation) cbOkiniName.SelectedItem;
            tbUrl.Text = favorite.URL.ToString();
        }

        public void RadioButton(string Urls) {

            try {
                lbRssTitle.Items.Clear();
                using (var wc = new WebClient()) {

                    var url = wc.OpenRead(Urls);
                    XDocument xdoc = XDocument.Load(url);
                    ITEMDATA = xdoc.Root.Descendants("item")
                                          .Select(x => new ItemData {
                                              Title = (string)x.Element("title"),
                                              Link = (string)x.Element("link"),
                                          }).ToList();

                    foreach (var node in ITEMDATA) {
                        lbRssTitle.Items.Add(node.Title);

                    }
                }
            }
            catch { }
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbUrl.Clear();
          
        }

        private void btAllClear_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();
            tbUrl.Clear();
            cbOkiniName.Items.Clear();
            tbURLBOX.Clear();
            tbOkiniName.Clear();
            wbBrowser.DocumentText = "";
            OKINIIRIDict.Clear();
            lbinfomation.Text = "";
            tbAtoName.Text = "";
            tbAtoURL.Text = "";
            OKINIIRIDict.Clear();
            cbATOYOMI.Items.Clear();

        }

        private void btdeath_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        

        private void btATOYOMI_Click(object sender, EventArgs e) {
            ATOYOMI ATOYOMI = new ATOYOMI(tbAtoURL.Text, tbAtoName.Text);

            if (tbAtoName.Text.Equals("") && tbAtoURL.Text.Equals("")) {
                lbinfomation.Text = "未入力では登録されません。";
            } else {
                if (ATOYOMIDict.ContainsKey(tbAtoURL.Text) || ATOYOMIDict.ContainsValue(tbAtoName.Text)) {
                    lbinfomation.Text = "既に登録されています。";


                } else {

                    lbinfomation.Text = " ";
                    ATOYOMIDict.Add(tbAtoURL.Text, tbAtoName.Text);
                    cbATOYOMI.Items.Add(ATOYOMI);

                    tbAtoName.Clear();
                    tbAtoURL.Clear();

                }
            }
        }

        private void cbATOYOMI_SelectedIndexChanged(object sender, EventArgs e) {
            ATOYOMI ATo= (ATOYOMI)cbATOYOMI.SelectedItem;
            wbBrowser.Navigate(ATo.AtoURL);
        }

        private void Form1_Load(object sender, EventArgs e) {
            var tool = new ToolTip();
            tool.InitialDelay = 0;
            tool.ReshowDelay = 0;
            tool.AutoPopDelay = 10000;

            tool.SetToolTip(btOKINIIRI, "お気に入りを登録できます。");
            tool.SetToolTip(btATOYOMI, "後で読む記事を登録できます。");
            tool.SetToolTip(btReflesh, "ウェブサイト更新");

        }

        private void btReflesh_Click(object sender, EventArgs e) {
            wbBrowser.Refresh();
        }
    }
}
