
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBackPage = new System.Windows.Forms.Button();
            this.btGopage = new System.Windows.Forms.Button();
            this.btOKINIIRI = new System.Windows.Forms.Button();
            this.btURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(162, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(799, 33);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btGet.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(1128, 4);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(105, 51);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbRssTitle.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(24, 51);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1098, 160);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedValueChanged += new System.EventHandler(this.lbRssTitle_SelectedValueChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(24, 222);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1209, 398);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBackPage
            // 
            this.btBackPage.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackPage.Location = new System.Drawing.Point(24, 12);
            this.btBackPage.Name = "btBackPage";
            this.btBackPage.Size = new System.Drawing.Size(119, 33);
            this.btBackPage.TabIndex = 5;
            this.btBackPage.Text = "＜前のぺージ";
            this.btBackPage.UseVisualStyleBackColor = true;
            this.btBackPage.Click += new System.EventHandler(this.btBackPage_Click);
            // 
            // btGopage
            // 
            this.btGopage.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGopage.Location = new System.Drawing.Point(976, 12);
            this.btGopage.Name = "btGopage";
            this.btGopage.Size = new System.Drawing.Size(136, 33);
            this.btGopage.TabIndex = 5;
            this.btGopage.Text = "後ろのページ＞";
            this.btGopage.UseVisualStyleBackColor = true;
            this.btGopage.Click += new System.EventHandler(this.btGopage_Click);
            // 
            // btOKINIIRI
            // 
            this.btOKINIIRI.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOKINIIRI.ForeColor = System.Drawing.Color.Gold;
            this.btOKINIIRI.Location = new System.Drawing.Point(1128, 61);
            this.btOKINIIRI.Name = "btOKINIIRI";
            this.btOKINIIRI.Size = new System.Drawing.Size(51, 54);
            this.btOKINIIRI.TabIndex = 6;
            this.btOKINIIRI.Text = "★";
            this.btOKINIIRI.UseVisualStyleBackColor = true;
            // 
            // btURL
            // 
            this.btURL.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btURL.Location = new System.Drawing.Point(1182, 61);
            this.btURL.Name = "btURL";
            this.btURL.Size = new System.Drawing.Size(51, 54);
            this.btURL.TabIndex = 6;
            this.btURL.Text = "URL";
            this.btURL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 642);
            this.Controls.Add(this.btURL);
            this.Controls.Add(this.btOKINIIRI);
            this.Controls.Add(this.btGopage);
            this.Controls.Add(this.btBackPage);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "サイト検索";
            this.MaximumSizeChanged += new System.EventHandler(this.btGet_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btBackPage;
        private System.Windows.Forms.Button btGopage;
        private System.Windows.Forms.Button btOKINIIRI;
        private System.Windows.Forms.Button btURL;
    }
}

