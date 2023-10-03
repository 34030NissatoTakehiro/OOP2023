using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
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

        private void lbRssTitle_SelectedValueChanged(object sender, EventArgs e) {
            var wb = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ITEMDATA[wb].Link);


            
        }
    }
}
