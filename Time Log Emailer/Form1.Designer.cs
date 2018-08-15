namespace Time_Log_Emailer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.btn_lunch = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_ReportTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Chekout = new System.Windows.Forms.TextBox();
            this.txtBox_Chekin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lunchLength = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_editReport = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_lunchCountdown = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBox_pw = new System.Windows.Forms.TextBox();
            this.chkBox_saveInfo = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lunchLength)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(9, 28);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(234, 20);
            this.txtBox_email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(168, 98);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Lock In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_checkin
            // 
            this.btn_checkin.Enabled = false;
            this.btn_checkin.Location = new System.Drawing.Point(6, 88);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(75, 59);
            this.btn_checkin.TabIndex = 0;
            this.btn_checkin.Text = "Check In";
            this.btn_checkin.UseVisualStyleBackColor = true;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // btn_lunch
            // 
            this.btn_lunch.Enabled = false;
            this.btn_lunch.Location = new System.Drawing.Point(87, 88);
            this.btn_lunch.Name = "btn_lunch";
            this.btn_lunch.Size = new System.Drawing.Size(75, 59);
            this.btn_lunch.TabIndex = 1;
            this.btn_lunch.Text = "Take Lunch";
            this.btn_lunch.UseVisualStyleBackColor = true;
            this.btn_lunch.Click += new System.EventHandler(this.btn_lunch_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Enabled = false;
            this.btn_checkout.Location = new System.Drawing.Point(168, 88);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(75, 59);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Report to:";
            // 
            // txtBox_ReportTo
            // 
            this.txtBox_ReportTo.Enabled = false;
            this.txtBox_ReportTo.Location = new System.Drawing.Point(67, 10);
            this.txtBox_ReportTo.Name = "txtBox_ReportTo";
            this.txtBox_ReportTo.Size = new System.Drawing.Size(174, 20);
            this.txtBox_ReportTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check-In Msg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Check-Out Msg:";
            // 
            // txtBox_Chekout
            // 
            this.txtBox_Chekout.Enabled = false;
            this.txtBox_Chekout.Location = new System.Drawing.Point(97, 64);
            this.txtBox_Chekout.Name = "txtBox_Chekout";
            this.txtBox_Chekout.Size = new System.Drawing.Size(144, 20);
            this.txtBox_Chekout.TabIndex = 4;
            // 
            // txtBox_Chekin
            // 
            this.txtBox_Chekin.Enabled = false;
            this.txtBox_Chekin.Location = new System.Drawing.Point(97, 43);
            this.txtBox_Chekin.Name = "txtBox_Chekin";
            this.txtBox_Chekin.Size = new System.Drawing.Size(144, 20);
            this.txtBox_Chekin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lunch Length:";
            // 
            // lunchLength
            // 
            this.lunchLength.Enabled = false;
            this.lunchLength.Location = new System.Drawing.Point(97, 94);
            this.lunchLength.Name = "lunchLength";
            this.lunchLength.Size = new System.Drawing.Size(47, 20);
            this.lunchLength.TabIndex = 7;
            this.lunchLength.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Minutes";
            // 
            // btn_editReport
            // 
            this.btn_editReport.Location = new System.Drawing.Point(85, 120);
            this.btn_editReport.Name = "btn_editReport";
            this.btn_editReport.Size = new System.Drawing.Size(75, 23);
            this.btn_editReport.TabIndex = 9;
            this.btn_editReport.Text = "Edit";
            this.btn_editReport.UseVisualStyleBackColor = true;
            this.btn_editReport.Click += new System.EventHandler(this.btn_editReport_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(5, 24);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(245, 46);
            this.lbl_Time.TabIndex = 7;
            this.lbl_Time.Text = "00:00:00 AM";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(261, 179);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.lbl_lunchCountdown);
            this.tabPage1.Controls.Add(this.lbl_Time);
            this.tabPage1.Controls.Add(this.btn_checkin);
            this.tabPage1.Controls.Add(this.btn_checkout);
            this.tabPage1.Controls.Add(this.btn_lunch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Time";
            // 
            // lbl_lunchCountdown
            // 
            this.lbl_lunchCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lunchCountdown.AutoSize = true;
            this.lbl_lunchCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lunchCountdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_lunchCountdown.Location = new System.Drawing.Point(70, 39);
            this.lbl_lunchCountdown.Name = "lbl_lunchCountdown";
            this.lbl_lunchCountdown.Size = new System.Drawing.Size(119, 46);
            this.lbl_lunchCountdown.TabIndex = 8;
            this.lbl_lunchCountdown.Text = "00:00";
            this.lbl_lunchCountdown.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.txtBox_pw);
            this.tabPage2.Controls.Add(this.chkBox_saveInfo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_login);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtBox_email);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(253, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account";
            // 
            // txtBox_pw
            // 
            this.txtBox_pw.Location = new System.Drawing.Point(12, 72);
            this.txtBox_pw.Name = "txtBox_pw";
            this.txtBox_pw.PasswordChar = '*';
            this.txtBox_pw.Size = new System.Drawing.Size(231, 20);
            this.txtBox_pw.TabIndex = 6;
            // 
            // chkBox_saveInfo
            // 
            this.chkBox_saveInfo.AutoSize = true;
            this.chkBox_saveInfo.Location = new System.Drawing.Point(12, 102);
            this.chkBox_saveInfo.Name = "chkBox_saveInfo";
            this.chkBox_saveInfo.Size = new System.Drawing.Size(100, 17);
            this.chkBox_saveInfo.TabIndex = 5;
            this.chkBox_saveInfo.Text = "Save Password";
            this.chkBox_saveInfo.UseVisualStyleBackColor = true;
            this.chkBox_saveInfo.Click += new System.EventHandler(this.chkBox_saveInfo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.btn_editReport);
            this.tabPage3.Controls.Add(this.txtBox_ReportTo);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lunchLength);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtBox_Chekin);
            this.tabPage3.Controls.Add(this.txtBox_Chekout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(253, 153);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporting";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 206);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enter email info";
            ((System.ComponentModel.ISupportInitialize)(this.lunchLength)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Button btn_lunch;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_ReportTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Chekout;
        private System.Windows.Forms.TextBox txtBox_Chekin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown lunchLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_editReport;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkBox_saveInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_lunchCountdown;
        private System.Windows.Forms.TextBox txtBox_pw;
    }
}

