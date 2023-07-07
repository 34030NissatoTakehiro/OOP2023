
namespace CalendarApp {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTimeNow = new System.Windows.Forms.TextBox();
            this.btage = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.btMinusYear = new System.Windows.Forms.Button();
            this.btPlusryear = new System.Windows.Forms.Button();
            this.btMinusMonth = new System.Windows.Forms.Button();
            this.btPlusMonth = new System.Windows.Forms.Button();
            this.btMinusDay = new System.Windows.Forms.Button();
            this.btPlusday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dtpDate.Location = new System.Drawing.Point(130, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(45, 76);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(159, 50);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(346, 113);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(321, 158);
            this.tbMessage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(40, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "現在時刻：";
            // 
            // tbTimeNow
            // 
            this.tbTimeNow.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTimeNow.Location = new System.Drawing.Point(181, 465);
            this.tbTimeNow.Multiline = true;
            this.tbTimeNow.Name = "tbTimeNow";
            this.tbTimeNow.Size = new System.Drawing.Size(557, 37);
            this.tbTimeNow.TabIndex = 10;
            // 
            // btage
            // 
            this.btage.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btage.Location = new System.Drawing.Point(45, 132);
            this.btage.Name = "btage";
            this.btage.Size = new System.Drawing.Size(159, 46);
            this.btage.TabIndex = 11;
            this.btage.Text = "年齢";
            this.btage.UseVisualStyleBackColor = true;
            this.btage.Click += new System.EventHandler(this.btage_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 1000;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // btMinusYear
            // 
            this.btMinusYear.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMinusYear.Location = new System.Drawing.Point(55, 257);
            this.btMinusYear.Name = "btMinusYear";
            this.btMinusYear.Size = new System.Drawing.Size(119, 51);
            this.btMinusYear.TabIndex = 4;
            this.btMinusYear.Text = "ー年";
            this.btMinusYear.UseVisualStyleBackColor = true;
            // 
            // btPlusryear
            // 
            this.btPlusryear.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPlusryear.Location = new System.Drawing.Point(200, 257);
            this.btPlusryear.Name = "btPlusryear";
            this.btPlusryear.Size = new System.Drawing.Size(110, 51);
            this.btPlusryear.TabIndex = 5;
            this.btPlusryear.Text = "＋年";
            this.btPlusryear.UseVisualStyleBackColor = true;
            // 
            // btMinusMonth
            // 
            this.btMinusMonth.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMinusMonth.Location = new System.Drawing.Point(55, 327);
            this.btMinusMonth.Name = "btMinusMonth";
            this.btMinusMonth.Size = new System.Drawing.Size(119, 50);
            this.btMinusMonth.TabIndex = 6;
            this.btMinusMonth.Text = "ー月";
            this.btMinusMonth.UseVisualStyleBackColor = true;
            // 
            // btPlusMonth
            // 
            this.btPlusMonth.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPlusMonth.Location = new System.Drawing.Point(200, 327);
            this.btPlusMonth.Name = "btPlusMonth";
            this.btPlusMonth.Size = new System.Drawing.Size(110, 50);
            this.btPlusMonth.TabIndex = 7;
            this.btPlusMonth.Text = "＋月";
            this.btPlusMonth.UseVisualStyleBackColor = true;
            // 
            // btMinusDay
            // 
            this.btMinusDay.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMinusDay.Location = new System.Drawing.Point(55, 399);
            this.btMinusDay.Name = "btMinusDay";
            this.btMinusDay.Size = new System.Drawing.Size(119, 46);
            this.btMinusDay.TabIndex = 8;
            this.btMinusDay.Text = "ー日";
            this.btMinusDay.UseVisualStyleBackColor = true;
            // 
            // btPlusday
            // 
            this.btPlusday.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPlusday.Location = new System.Drawing.Point(200, 399);
            this.btPlusday.Name = "btPlusday";
            this.btPlusday.Size = new System.Drawing.Size(110, 46);
            this.btPlusday.TabIndex = 9;
            this.btPlusday.Text = "＋日";
            this.btPlusday.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 523);
            this.Controls.Add(this.btage);
            this.Controls.Add(this.tbTimeNow);
            this.Controls.Add(this.btPlusday);
            this.Controls.Add(this.btMinusDay);
            this.Controls.Add(this.btPlusMonth);
            this.Controls.Add(this.btMinusMonth);
            this.Controls.Add(this.btPlusryear);
            this.Controls.Add(this.btMinusYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTimeNow;
        private System.Windows.Forms.Button btage;
        private System.Windows.Forms.Timer tmTimeDisp;
        private System.Windows.Forms.Button btMinusYear;
        private System.Windows.Forms.Button btPlusryear;
        private System.Windows.Forms.Button btMinusMonth;
        private System.Windows.Forms.Button btPlusMonth;
        private System.Windows.Forms.Button btMinusDay;
        private System.Windows.Forms.Button btPlusday;
    }
}

