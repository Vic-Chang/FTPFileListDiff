
namespace FTPFileListInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ftpPath = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ftpIp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_files = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cb_image = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_excel = new System.Windows.Forms.CheckBox();
            this.cb_pdf = new System.Windows.Forms.CheckBox();
            this.cb_txt = new System.Windows.Forms.CheckBox();
            this.lb_filesCount = new System.Windows.Forms.Label();
            this.btn_exportTxt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_diff = new System.Windows.Forms.Button();
            this.lv_diff = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_localPath = new System.Windows.Forms.TextBox();
            this.btn_ExportDiff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ftpPath
            // 
            this.tb_ftpPath.Location = new System.Drawing.Point(76, 97);
            this.tb_ftpPath.Name = "tb_ftpPath";
            this.tb_ftpPath.Size = new System.Drawing.Size(288, 23);
            this.tb_ftpPath.TabIndex = 0;
            // 
            // btn_run
            // 
            this.btn_run.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_run.Location = new System.Drawing.Point(300, 160);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "抓取資料";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_ClickAsync);
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(212, 31);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(113, 23);
            this.tb_account.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(374, 31);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(112, 23);
            this.tb_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "抓取路徑:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "帳號:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "密碼:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ftpIp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_account);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP帳號密碼";
            // 
            // tb_ftpIp
            // 
            this.tb_ftpIp.Location = new System.Drawing.Point(53, 31);
            this.tb_ftpIp.Name = "tb_ftpIp";
            this.tb_ftpIp.Size = new System.Drawing.Size(113, 23);
            this.tb_ftpIp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP:";
            // 
            // lv_files
            // 
            this.lv_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_files.HideSelection = false;
            this.lv_files.Location = new System.Drawing.Point(12, 204);
            this.lv_files.Name = "lv_files";
            this.lv_files.Size = new System.Drawing.Size(363, 239);
            this.lv_files.TabIndex = 9;
            this.lv_files.UseCompatibleStateImageBehavior = false;
            this.lv_files.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "檔案名稱";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "類型";
            this.columnHeader2.Width = 287;
            // 
            // cb_image
            // 
            this.cb_image.AutoSize = true;
            this.cb_image.Checked = true;
            this.cb_image.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_image.Location = new System.Drawing.Point(17, 27);
            this.cb_image.Name = "cb_image";
            this.cb_image.Size = new System.Drawing.Size(50, 19);
            this.cb_image.TabIndex = 10;
            this.cb_image.Text = "圖片";
            this.cb_image.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_excel);
            this.groupBox2.Controls.Add(this.cb_pdf);
            this.groupBox2.Controls.Add(this.cb_txt);
            this.groupBox2.Controls.Add(this.cb_image);
            this.groupBox2.Location = new System.Drawing.Point(13, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 63);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "抓取類型";
            // 
            // cb_excel
            // 
            this.cb_excel.AutoSize = true;
            this.cb_excel.Location = new System.Drawing.Point(192, 27);
            this.cb_excel.Name = "cb_excel";
            this.cb_excel.Size = new System.Drawing.Size(62, 19);
            this.cb_excel.TabIndex = 13;
            this.cb_excel.Text = "EXCEL";
            this.cb_excel.UseVisualStyleBackColor = true;
            // 
            // cb_pdf
            // 
            this.cb_pdf.AutoSize = true;
            this.cb_pdf.Location = new System.Drawing.Point(138, 27);
            this.cb_pdf.Name = "cb_pdf";
            this.cb_pdf.Size = new System.Drawing.Size(48, 19);
            this.cb_pdf.TabIndex = 12;
            this.cb_pdf.Text = "PDF";
            this.cb_pdf.UseVisualStyleBackColor = true;
            // 
            // cb_txt
            // 
            this.cb_txt.AutoSize = true;
            this.cb_txt.Location = new System.Drawing.Point(70, 27);
            this.cb_txt.Name = "cb_txt";
            this.cb_txt.Size = new System.Drawing.Size(62, 19);
            this.cb_txt.TabIndex = 11;
            this.cb_txt.Text = "文字檔";
            this.cb_txt.UseVisualStyleBackColor = true;
            // 
            // lb_filesCount
            // 
            this.lb_filesCount.AutoSize = true;
            this.lb_filesCount.Location = new System.Drawing.Point(13, 453);
            this.lb_filesCount.Name = "lb_filesCount";
            this.lb_filesCount.Size = new System.Drawing.Size(10, 15);
            this.lb_filesCount.TabIndex = 12;
            this.lb_filesCount.Text = " ";
            // 
            // btn_exportTxt
            // 
            this.btn_exportTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_exportTxt.Enabled = false;
            this.btn_exportTxt.Location = new System.Drawing.Point(425, 449);
            this.btn_exportTxt.Name = "btn_exportTxt";
            this.btn_exportTxt.Size = new System.Drawing.Size(157, 23);
            this.btn_exportTxt.TabIndex = 13;
            this.btn_exportTxt.Text = "匯出FTP清單成文字檔";
            this.btn_exportTxt.UseVisualStyleBackColor = true;
            this.btn_exportTxt.Click += new System.EventHandler(this.btn_exportTxt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_diff);
            this.groupBox3.Controls.Add(this.lv_diff);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_localPath);
            this.groupBox3.Location = new System.Drawing.Point(389, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 343);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "差異比對";
            // 
            // btn_diff
            // 
            this.btn_diff.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_diff.Enabled = false;
            this.btn_diff.Location = new System.Drawing.Point(133, 81);
            this.btn_diff.Name = "btn_diff";
            this.btn_diff.Size = new System.Drawing.Size(102, 23);
            this.btn_diff.TabIndex = 15;
            this.btn_diff.Text = "執行差異比對";
            this.btn_diff.UseVisualStyleBackColor = true;
            this.btn_diff.Click += new System.EventHandler(this.btn_diff_Click);
            // 
            // lv_diff
            // 
            this.lv_diff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lv_diff.HideSelection = false;
            this.lv_diff.Location = new System.Drawing.Point(7, 124);
            this.lv_diff.Name = "lv_diff";
            this.lv_diff.Size = new System.Drawing.Size(363, 199);
            this.lv_diff.TabIndex = 15;
            this.lv_diff.UseCompatibleStateImageBehavior = false;
            this.lv_diff.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "檔案名稱";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "誰缺檔";
            this.columnHeader4.Width = 287;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "本機路徑:";
            // 
            // tb_localPath
            // 
            this.tb_localPath.Location = new System.Drawing.Point(82, 39);
            this.tb_localPath.Name = "tb_localPath";
            this.tb_localPath.ReadOnly = true;
            this.tb_localPath.Size = new System.Drawing.Size(288, 23);
            this.tb_localPath.TabIndex = 5;
            // 
            // btn_ExportDiff
            // 
            this.btn_ExportDiff.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ExportDiff.Enabled = false;
            this.btn_ExportDiff.Location = new System.Drawing.Point(588, 449);
            this.btn_ExportDiff.Name = "btn_ExportDiff";
            this.btn_ExportDiff.Size = new System.Drawing.Size(157, 23);
            this.btn_ExportDiff.TabIndex = 15;
            this.btn_ExportDiff.Text = "匯出差異比對清單";
            this.btn_ExportDiff.UseVisualStyleBackColor = true;
            this.btn_ExportDiff.Click += new System.EventHandler(this.btn_ExportDiff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 480);
            this.Controls.Add(this.btn_ExportDiff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_exportTxt);
            this.Controls.Add(this.lb_filesCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lv_files);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tb_ftpPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FTP 資料清單";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ftpPath;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_files;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox cb_image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_excel;
        private System.Windows.Forms.CheckBox cb_pdf;
        private System.Windows.Forms.CheckBox cb_txt;
        private System.Windows.Forms.Label lb_filesCount;
        private System.Windows.Forms.Button btn_exportTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_diff;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_localPath;
        private System.Windows.Forms.Button btn_diff;
        private System.Windows.Forms.TextBox tb_ftpIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ExportDiff;
    }
}

