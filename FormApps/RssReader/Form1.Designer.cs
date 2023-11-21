
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
            this.tbCartop = new System.Windows.Forms.RadioButton();
            this.rbMotorsports = new System.Windows.Forms.RadioButton();
            this.rbBasketBall = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.tbOkiniName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbOkiniName = new System.Windows.Forms.ComboBox();
            this.tbURLBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbinfomation = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btAllClear = new System.Windows.Forms.Button();
            this.btReflesh = new System.Windows.Forms.Button();
            this.btdeath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAtoName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAtoURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btATOYOMI = new System.Windows.Forms.Button();
            this.cbATOYOMI = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(161, 5);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(831, 38);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btGet.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(919, 217);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(301, 34);
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
            this.lbRssTitle.Size = new System.Drawing.Size(1203, 160);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(24, 217);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(876, 398);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBackPage
            // 
            this.btBackPage.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackPage.Location = new System.Drawing.Point(24, 5);
            this.btBackPage.Name = "btBackPage";
            this.btBackPage.Size = new System.Drawing.Size(119, 38);
            this.btBackPage.TabIndex = 5;
            this.btBackPage.Text = "＜前のぺージ";
            this.btBackPage.UseVisualStyleBackColor = true;
            this.btBackPage.Click += new System.EventHandler(this.btBackPage_Click);
            // 
            // btGopage
            // 
            this.btGopage.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGopage.Location = new System.Drawing.Point(1091, 5);
            this.btGopage.Name = "btGopage";
            this.btGopage.Size = new System.Drawing.Size(136, 38);
            this.btGopage.TabIndex = 5;
            this.btGopage.Text = "後ろのページ＞";
            this.btGopage.UseVisualStyleBackColor = true;
            this.btGopage.Click += new System.EventHandler(this.btGopage_Click);
            // 
            // btOKINIIRI
            // 
            this.btOKINIIRI.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOKINIIRI.ForeColor = System.Drawing.Color.Gold;
            this.btOKINIIRI.Location = new System.Drawing.Point(1179, 325);
            this.btOKINIIRI.Name = "btOKINIIRI";
            this.btOKINIIRI.Size = new System.Drawing.Size(51, 54);
            this.btOKINIIRI.TabIndex = 6;
            this.btOKINIIRI.Text = "★";
            this.btOKINIIRI.UseVisualStyleBackColor = true;
            this.btOKINIIRI.Click += new System.EventHandler(this.btOKINIIRI_Click);
            // 
            // tbCartop
            // 
            this.tbCartop.AutoSize = true;
            this.tbCartop.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCartop.Location = new System.Drawing.Point(15, 34);
            this.tbCartop.Name = "tbCartop";
            this.tbCartop.Size = new System.Drawing.Size(102, 32);
            this.tbCartop.TabIndex = 7;
            this.tbCartop.TabStop = true;
            this.tbCartop.Text = "CARTOP";
            this.tbCartop.UseVisualStyleBackColor = true;
            this.tbCartop.CheckedChanged += new System.EventHandler(this.tbCartop_CheckedChanged);
            // 
            // rbMotorsports
            // 
            this.rbMotorsports.AutoSize = true;
            this.rbMotorsports.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbMotorsports.Location = new System.Drawing.Point(15, 110);
            this.rbMotorsports.Name = "rbMotorsports";
            this.rbMotorsports.Size = new System.Drawing.Size(227, 32);
            this.rbMotorsports.TabIndex = 8;
            this.rbMotorsports.TabStop = true;
            this.rbMotorsports.Text = "MOTORSPORTS";
            this.rbMotorsports.UseVisualStyleBackColor = true;
            this.rbMotorsports.CheckedChanged += new System.EventHandler(this.rbMotorsports_CheckedChanged);
            // 
            // rbBasketBall
            // 
            this.rbBasketBall.AllowDrop = true;
            this.rbBasketBall.AutoSize = true;
            this.rbBasketBall.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbBasketBall.Location = new System.Drawing.Point(15, 72);
            this.rbBasketBall.Name = "rbBasketBall";
            this.rbBasketBall.Size = new System.Drawing.Size(197, 32);
            this.rbBasketBall.TabIndex = 9;
            this.rbBasketBall.TabStop = true;
            this.rbBasketBall.Text = "BASKETBALL";
            this.rbBasketBall.UseVisualStyleBackColor = true;
            this.rbBasketBall.CheckedChanged += new System.EventHandler(this.rbBasketBall_CheckedChanged);
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbIT.Location = new System.Drawing.Point(15, 148);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(58, 32);
            this.rbIT.TabIndex = 10;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rbIT_CheckedChanged);
            // 
            // tbOkiniName
            // 
            this.tbOkiniName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOkiniName.Location = new System.Drawing.Point(976, 257);
            this.tbOkiniName.Name = "tbOkiniName";
            this.tbOkiniName.Size = new System.Drawing.Size(254, 23);
            this.tbOkiniName.TabIndex = 11;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbName.Location = new System.Drawing.Point(915, 261);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 24);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "名前";
            // 
            // cbOkiniName
            // 
            this.cbOkiniName.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbOkiniName.FormattingEnabled = true;
            this.cbOkiniName.Location = new System.Drawing.Point(919, 342);
            this.cbOkiniName.Name = "cbOkiniName";
            this.cbOkiniName.Size = new System.Drawing.Size(254, 37);
            this.cbOkiniName.TabIndex = 14;
            this.cbOkiniName.SelectedIndexChanged += new System.EventHandler(this.cbOkiniName_SelectedIndexChanged);
            // 
            // tbURLBOX
            // 
            this.tbURLBOX.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbURLBOX.Location = new System.Drawing.Point(976, 291);
            this.tbURLBOX.Name = "tbURLBOX";
            this.tbURLBOX.Size = new System.Drawing.Size(251, 28);
            this.tbURLBOX.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(124, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCartop);
            this.groupBox1.Controls.Add(this.rbBasketBall);
            this.groupBox1.Controls.Add(this.rbMotorsports);
            this.groupBox1.Controls.Add(this.rbIT);
            this.groupBox1.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(919, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 192);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "名称一覧";
            // 
            // lbinfomation
            // 
            this.lbinfomation.AutoSize = true;
            this.lbinfomation.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbinfomation.ForeColor = System.Drawing.Color.Red;
            this.lbinfomation.Location = new System.Drawing.Point(929, 382);
            this.lbinfomation.Name = "lbinfomation";
            this.lbinfomation.Size = new System.Drawing.Size(0, 28);
            this.lbinfomation.TabIndex = 18;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(998, 5);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(42, 40);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "×";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAllClear
            // 
            this.btAllClear.BackColor = System.Drawing.Color.Red;
            this.btAllClear.Font = new System.Drawing.Font("游明朝 Demibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAllClear.ForeColor = System.Drawing.Color.Transparent;
            this.btAllClear.Location = new System.Drawing.Point(1179, 495);
            this.btAllClear.Name = "btAllClear";
            this.btAllClear.Size = new System.Drawing.Size(53, 120);
            this.btAllClear.TabIndex = 20;
            this.btAllClear.Text = "リ\r\nセ\r\nッ\r\nト";
            this.btAllClear.UseVisualStyleBackColor = false;
            this.btAllClear.Click += new System.EventHandler(this.btAllClear_Click);
            // 
            // btReflesh
            // 
            this.btReflesh.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReflesh.Location = new System.Drawing.Point(1046, 5);
            this.btReflesh.Name = "btReflesh";
            this.btReflesh.Size = new System.Drawing.Size(39, 42);
            this.btReflesh.TabIndex = 21;
            this.btReflesh.Text = "🔄\r\n";
            this.btReflesh.UseVisualStyleBackColor = true;
            this.btReflesh.Click += new System.EventHandler(this.btReflesh_Click);
            // 
            // btdeath
            // 
            this.btdeath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btdeath.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btdeath.ForeColor = System.Drawing.Color.Maroon;
            this.btdeath.Location = new System.Drawing.Point(1182, 423);
            this.btdeath.Name = "btdeath";
            this.btdeath.Size = new System.Drawing.Size(50, 66);
            this.btdeath.TabIndex = 22;
            this.btdeath.Text = "終了";
            this.btdeath.UseVisualStyleBackColor = false;
            this.btdeath.Click += new System.EventHandler(this.btdeath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "後で読む";
            // 
            // tbAtoName
            // 
            this.tbAtoName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAtoName.Location = new System.Drawing.Point(188, 623);
            this.tbAtoName.Name = "tbAtoName";
            this.tbAtoName.Size = new System.Drawing.Size(712, 31);
            this.tbAtoName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(124, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "記事";
            // 
            // tbAtoURL
            // 
            this.tbAtoURL.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAtoURL.Location = new System.Drawing.Point(193, 660);
            this.tbAtoURL.Name = "tbAtoURL";
            this.tbAtoURL.Size = new System.Drawing.Size(707, 31);
            this.tbAtoURL.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(915, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "URL";
            // 
            // btATOYOMI
            // 
            this.btATOYOMI.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btATOYOMI.Location = new System.Drawing.Point(1152, 664);
            this.btATOYOMI.Name = "btATOYOMI";
            this.btATOYOMI.Size = new System.Drawing.Size(75, 37);
            this.btATOYOMI.TabIndex = 26;
            this.btATOYOMI.Text = "登録";
            this.btATOYOMI.UseVisualStyleBackColor = true;
            this.btATOYOMI.Click += new System.EventHandler(this.btATOYOMI_Click);
            // 
            // cbATOYOMI
            // 
            this.cbATOYOMI.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbATOYOMI.FormattingEnabled = true;
            this.cbATOYOMI.Location = new System.Drawing.Point(919, 626);
            this.cbATOYOMI.Name = "cbATOYOMI";
            this.cbATOYOMI.Size = new System.Drawing.Size(305, 32);
            this.cbATOYOMI.TabIndex = 27;
            this.cbATOYOMI.SelectedIndexChanged += new System.EventHandler(this.cbATOYOMI_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 709);
            this.Controls.Add(this.cbATOYOMI);
            this.Controls.Add(this.btATOYOMI);
            this.Controls.Add(this.tbAtoURL);
            this.Controls.Add(this.tbAtoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdeath);
            this.Controls.Add(this.btReflesh);
            this.Controls.Add(this.btAllClear);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbinfomation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbURLBOX);
            this.Controls.Add(this.cbOkiniName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbOkiniName);
            this.Controls.Add(this.btOKINIIRI);
            this.Controls.Add(this.btGopage);
            this.Controls.Add(this.btBackPage);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "サイト検索";
            this.MaximumSizeChanged += new System.EventHandler(this.btGet_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton tbCartop;
        private System.Windows.Forms.RadioButton rbMotorsports;
        private System.Windows.Forms.RadioButton rbBasketBall;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.TextBox tbOkiniName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbOkiniName;
        private System.Windows.Forms.TextBox tbURLBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbinfomation;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btAllClear;
        private System.Windows.Forms.Button btReflesh;
        private System.Windows.Forms.Button btdeath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAtoName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAtoURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btATOYOMI;
        private System.Windows.Forms.ComboBox cbATOYOMI;
    }
}

