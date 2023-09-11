
namespace CarReportSystem {
    partial class btAutherSearch {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbImported = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbDaihatsu = new System.Windows.Forms.RadioButton();
            this.rbSuzuki = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btModifyReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.menuItems = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dB接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdimageFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusDisp = new System.Windows.Forms.StatusStrip();
            this.tsTimeDisp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.btScaleChange = new System.Windows.Forms.Button();
            this.tmTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.ofbCarRepoOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdCarRepoSave = new System.Windows.Forms.SaveFileDialog();
            this.tbAutherSeach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCarNameSearch = new System.Windows.Forms.Button();
            this.btAutherSeachi = new System.Windows.Forms.Button();
            this.tbCarNameSeach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202306DataSet = new CarReportSystem.infosys202306DataSet();
            this.carReportTableTableAdapter = new CarReportSystem.infosys202306DataSetTableAdapters.CarReportTableTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202306DataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btDateTimeSeach = new System.Windows.Forms.Button();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.menuItems.SuspendLayout();
            this.statusDisp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202306DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(138, 47);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(418, 28);
            this.dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "記録者：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(138, 119);
            this.cbAuthor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(418, 29);
            this.cbAuthor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "メーカー：";
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbImported);
            this.gbMaker.Controls.Add(this.rbOther);
            this.gbMaker.Controls.Add(this.rbDaihatsu);
            this.gbMaker.Controls.Add(this.rbSuzuki);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(140, 178);
            this.gbMaker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbMaker.Size = new System.Drawing.Size(556, 142);
            this.gbMaker.TabIndex = 3;
            this.gbMaker.TabStop = false;
            // 
            // rbImported
            // 
            this.rbImported.AutoSize = true;
            this.rbImported.Location = new System.Drawing.Point(422, 33);
            this.rbImported.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbImported.Name = "rbImported";
            this.rbImported.Size = new System.Drawing.Size(91, 25);
            this.rbImported.TabIndex = 6;
            this.rbImported.TabStop = true;
            this.rbImported.Tag = "6";
            this.rbImported.Text = "輸入車";
            this.rbImported.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(424, 89);
            this.rbOther.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(87, 25);
            this.rbOther.TabIndex = 10;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "7";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbDaihatsu
            // 
            this.rbDaihatsu.AutoSize = true;
            this.rbDaihatsu.Location = new System.Drawing.Point(270, 89);
            this.rbDaihatsu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbDaihatsu.Name = "rbDaihatsu";
            this.rbDaihatsu.Size = new System.Drawing.Size(105, 25);
            this.rbDaihatsu.TabIndex = 9;
            this.rbDaihatsu.TabStop = true;
            this.rbDaihatsu.Tag = "5";
            this.rbDaihatsu.Text = "ダイハツ";
            this.rbDaihatsu.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            this.rbSuzuki.AutoSize = true;
            this.rbSuzuki.Location = new System.Drawing.Point(140, 89);
            this.rbSuzuki.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbSuzuki.Name = "rbSuzuki";
            this.rbSuzuki.Size = new System.Drawing.Size(84, 25);
            this.rbSuzuki.TabIndex = 8;
            this.rbSuzuki.TabStop = true;
            this.rbSuzuki.Tag = "4";
            this.rbSuzuki.Text = "スズキ";
            this.rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(14, 89);
            this.rbSubaru.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(85, 25);
            this.rbSubaru.TabIndex = 7;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(270, 32);
            this.rbHonda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(87, 25);
            this.rbHonda.TabIndex = 5;
            this.rbHonda.TabStop = true;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(140, 33);
            this.rbNissan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(70, 25);
            this.rbNissan.TabIndex = 4;
            this.rbNissan.TabStop = true;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(14, 33);
            this.rbToyota.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(80, 25);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(138, 346);
            this.cbCarName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(418, 29);
            this.cbCarName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "レポート：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(140, 422);
            this.tbReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(538, 235);
            this.tbReport.TabIndex = 5;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.AutoGenerateColumns = false;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.autherDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvCarReports.DataSource = this.carReportTableBindingSource;
            this.dgvCarReports.Location = new System.Drawing.Point(125, 804);
            this.dgvCarReports.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.ReadOnly = true;
            this.dgvCarReports.RowHeadersVisible = false;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(1165, 275);
            this.dgvCarReports.TabIndex = 8;
            this.dgvCarReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellClick);
            this.dgvCarReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 804);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btImageOpen.Location = new System.Drawing.Point(802, 38);
            this.btImageOpen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(150, 40);
            this.btImageOpen.TabIndex = 6;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(964, 38);
            this.btImageDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(150, 40);
            this.btImageDelete.TabIndex = 7;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.Color.Black;
            this.pbCarImage.Location = new System.Drawing.Point(724, 89);
            this.pbCarImage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(566, 331);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 11;
            this.pbCarImage.TabStop = false;
            // 
            // btAddReport
            // 
            this.btAddReport.BackColor = System.Drawing.Color.Lime;
            this.btAddReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddReport.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddReport.Location = new System.Drawing.Point(724, 446);
            this.btAddReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(168, 214);
            this.btAddReport.TabIndex = 9;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = false;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // btModifyReport
            // 
            this.btModifyReport.BackColor = System.Drawing.Color.Yellow;
            this.btModifyReport.Enabled = false;
            this.btModifyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModifyReport.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btModifyReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btModifyReport.Location = new System.Drawing.Point(918, 446);
            this.btModifyReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btModifyReport.Name = "btModifyReport";
            this.btModifyReport.Size = new System.Drawing.Size(168, 214);
            this.btModifyReport.TabIndex = 10;
            this.btModifyReport.Text = "修正";
            this.btModifyReport.UseVisualStyleBackColor = false;
            this.btModifyReport.Click += new System.EventHandler(this.btModifyReport_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.BackColor = System.Drawing.Color.Red;
            this.btDeleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteReport.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeleteReport.Location = new System.Drawing.Point(1122, 446);
            this.btDeleteReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(168, 214);
            this.btDeleteReport.TabIndex = 11;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = false;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // menuItems
            // 
            this.menuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuItems.Location = new System.Drawing.Point(0, 0);
            this.menuItems.Name = "menuItems";
            this.menuItems.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuItems.Size = new System.Drawing.Size(1605, 27);
            this.menuItems.TabIndex = 13;
            this.menuItems.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存SToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem,
            this.toolStripSeparator3,
            this.dB接続ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.保存SToolStripMenuItem.Text = "保存...(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // dB接続ToolStripMenuItem
            // 
            this.dB接続ToolStripMenuItem.Name = "dB接続ToolStripMenuItem";
            this.dB接続ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.dB接続ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dB接続ToolStripMenuItem.Text = "DB接続(&N)";
            this.dB接続ToolStripMenuItem.Click += new System.EventHandler(this.dB接続ToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.色設定ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 色設定ToolStripMenuItem
            // 
            this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.色設定ToolStripMenuItem.Text = "色設定...";
            this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン設定ToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン設定ToolStripMenuItem
            // 
            this.バージョン設定ToolStripMenuItem.Name = "バージョン設定ToolStripMenuItem";
            this.バージョン設定ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.バージョン設定ToolStripMenuItem.Text = "バージョン設定";
            this.バージョン設定ToolStripMenuItem.Click += new System.EventHandler(this.バージョン設定ToolStripMenuItem_Click);
            // 
            // ofdimageFileOpen
            // 
            this.ofdimageFileOpen.FileName = "openFileDialog1";
            // 
            // statusDisp
            // 
            this.statusDisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTimeDisp,
            this.tsInfoText});
            this.statusDisp.Location = new System.Drawing.Point(0, 1079);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Size = new System.Drawing.Size(1605, 22);
            this.statusDisp.TabIndex = 14;
            this.statusDisp.Text = "statusStrip1";
            // 
            // tsTimeDisp
            // 
            this.tsTimeDisp.Name = "tsTimeDisp";
            this.tsTimeDisp.Size = new System.Drawing.Size(55, 17);
            this.tsTimeDisp.Text = "時刻表示";
            // 
            // tsInfoText
            // 
            this.tsInfoText.Name = "tsInfoText";
            this.tsInfoText.Size = new System.Drawing.Size(59, 17);
            this.tsInfoText.Text = "プロパティー";
            // 
            // btScaleChange
            // 
            this.btScaleChange.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btScaleChange.Location = new System.Drawing.Point(1122, 38);
            this.btScaleChange.Name = "btScaleChange";
            this.btScaleChange.Size = new System.Drawing.Size(150, 40);
            this.btScaleChange.TabIndex = 8;
            this.btScaleChange.Text = "サイズ変更";
            this.btScaleChange.UseVisualStyleBackColor = true;
            this.btScaleChange.Click += new System.EventHandler(this.btScaleChange_Click);
            // 
            // tmTimeUpdate
            // 
            this.tmTimeUpdate.Tick += new System.EventHandler(this.tmTimeUpdate_Tick);
            // 
            // ofbCarRepoOpen
            // 
            this.ofbCarRepoOpen.FileName = "openFileDialog1";
            // 
            // tbAutherSeach
            // 
            this.tbAutherSeach.Location = new System.Drawing.Point(100, 24);
            this.tbAutherSeach.Name = "tbAutherSeach";
            this.tbAutherSeach.Size = new System.Drawing.Size(174, 28);
            this.tbAutherSeach.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "記録者：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btCarNameSearch);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btAutherSeachi);
            this.groupBox1.Controls.Add(this.tbCarNameSeach);
            this.groupBox1.Controls.Add(this.tbAutherSeach);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(140, 682);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 114);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // btCarNameSearch
            // 
            this.btCarNameSearch.Location = new System.Drawing.Point(922, 26);
            this.btCarNameSearch.Name = "btCarNameSearch";
            this.btCarNameSearch.Size = new System.Drawing.Size(141, 32);
            this.btCarNameSearch.TabIndex = 18;
            this.btCarNameSearch.Text = "車名で検索";
            this.btCarNameSearch.UseVisualStyleBackColor = true;
            this.btCarNameSearch.Click += new System.EventHandler(this.btCarNameSearch_Click);
            // 
            // btAutherSeachi
            // 
            this.btAutherSeachi.Location = new System.Drawing.Point(318, 17);
            this.btAutherSeachi.Name = "btAutherSeachi";
            this.btAutherSeachi.Size = new System.Drawing.Size(164, 41);
            this.btAutherSeachi.TabIndex = 18;
            this.btAutherSeachi.Text = "記録者で検索";
            this.btAutherSeachi.UseVisualStyleBackColor = true;
            this.btAutherSeachi.Click += new System.EventHandler(this.btAutherSeachi_Click);
            // 
            // tbCarNameSeach
            // 
            this.tbCarNameSeach.Location = new System.Drawing.Point(662, 24);
            this.tbCarNameSeach.Name = "tbCarNameSeach";
            this.tbCarNameSeach.Size = new System.Drawing.Size(232, 28);
            this.tbCarNameSeach.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "日付：";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autherDataGridViewTextBoxColumn
            // 
            this.autherDataGridViewTextBoxColumn.DataPropertyName = "Auther";
            this.autherDataGridViewTextBoxColumn.HeaderText = "Auther";
            this.autherDataGridViewTextBoxColumn.Name = "autherDataGridViewTextBoxColumn";
            this.autherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            this.makerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // carReportTableBindingSource
            // 
            this.carReportTableBindingSource.DataMember = "CarReportTable";
            this.carReportTableBindingSource.DataSource = this.infosys202306DataSet;
            // 
            // infosys202306DataSet
            // 
            this.infosys202306DataSet.DataSetName = "infosys202306DataSet";
            this.infosys202306DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportTableTableAdapter
            // 
            this.carReportTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableTableAdapter = this.carReportTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202306DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 28);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "日付：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "車名で検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btCarNameSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "記録者で検索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btAutherSeachi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.btDateTimeSeach);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(140, 682);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1132, 114);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(319, 28);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "車名で検索";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btCarNameSearch_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(922, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "車名で検索";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btCarNameSearch_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(318, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 41);
            this.button6.TabIndex = 18;
            this.button6.Text = "記録者で検索";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btAutherSeachi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(662, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 28);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 28);
            this.textBox2.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "日付：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "日付：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "記録者：";
            // 
            // btDateTimeSeach
            // 
            this.btDateTimeSeach.Location = new System.Drawing.Point(476, 64);
            this.btDateTimeSeach.Name = "btDateTimeSeach";
            this.btDateTimeSeach.Size = new System.Drawing.Size(121, 39);
            this.btDateTimeSeach.TabIndex = 20;
            this.btDateTimeSeach.Text = "日付検索";
            this.btDateTimeSeach.UseVisualStyleBackColor = true;
            this.btDateTimeSeach.Click += new System.EventHandler(this.btDateTimeSeach_Click);
            // 
            // btAutherSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1622, 1061);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btScaleChange);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btModifyReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuItems);
            this.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuItems;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "btAutherSearch";
            this.Text = "カーレポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.menuItems.ResumeLayout(false);
            this.menuItems.PerformLayout();
            this.statusDisp.ResumeLayout(false);
            this.statusDisp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202306DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbImported;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbDaihatsu;
        private System.Windows.Forms.RadioButton rbSuzuki;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btModifyReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.MenuStrip menuItems;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdimageFileOpen;
        private System.Windows.Forms.StatusStrip statusDisp;
        private System.Windows.Forms.ToolStripStatusLabel tsInfoText;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン設定ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Button btScaleChange;
        private System.Windows.Forms.ToolStripStatusLabel tsTimeDisp;
        private System.Windows.Forms.Timer tmTimeUpdate;
        private System.Windows.Forms.OpenFileDialog ofbCarRepoOpen;
        private System.Windows.Forms.SaveFileDialog sfdCarRepoSave;
        private infosys202306DataSet infosys202306DataSet;
        private System.Windows.Forms.BindingSource carReportTableBindingSource;
        private infosys202306DataSetTableAdapters.CarReportTableTableAdapter carReportTableTableAdapter;
        private infosys202306DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripMenuItem dB接続ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox tbAutherSeach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCarNameSeach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCarNameSearch;
        private System.Windows.Forms.Button btAutherSeachi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btDateTimeSeach;
    }
}

