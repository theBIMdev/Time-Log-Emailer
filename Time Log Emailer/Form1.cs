using System;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Time_Log_Emailer
{
    public partial class Form1 : Form
    {
        TimeSpan lunchDuration = new TimeSpan();
        DateTime lunchEndsAt = new DateTime();

        public Form1()
        {
            InitializeComponent();
            lbl_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();

            txtBox_email.Text = ConfigurationManager.AppSettings["email"];
            string pw = ConfigurationManager.AppSettings["password"];
            if (pw != "") { chkBox_saveInfo.Checked = true; txtBox_pw.Text = pw; }
            if (txtBox_email.Text != "" && pw != "") { log(); }
            txtBox_ReportTo.Text = ConfigurationManager.AppSettings["sendto"];
            txtBox_Chekin.Text = ConfigurationManager.AppSettings["checkin"];
            txtBox_Chekout.Text = ConfigurationManager.AppSettings["checkout"];
            lunchLength.Value = Convert.ToInt32(ConfigurationManager.AppSettings["lunchlength"]);
            lunchDuration = TimeSpan.FromMinutes(Convert.ToDouble(lunchLength.Value));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (lbl_lunchCountdown.Visible == true)
            {
                lbl_lunchCountdown.Text = getTimeLeft(lunchEndsAt);
            }
        }

        private void btn_editReport_Click(object sender, EventArgs e)
        {
            if (btn_editReport.Text == "Save")
            {
                //Disable all edit boxes and save the new values.
                txtBox_ReportTo.Enabled = false;
                txtBox_Chekin.Enabled = false;
                txtBox_Chekout.Enabled = false;
                lunchLength.Enabled = false;
                btn_editReport.Text = "Edit";
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;

                    settings["sendto"].Value = txtBox_ReportTo.Text;
                    settings["checkin"].Value = txtBox_Chekin.Text;
                    settings["checkout"].Value = txtBox_Chekout.Text;
                    settings["lunchlength"].Value = lunchLength.Value.ToString();

                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                catch (ConfigurationErrorsException)
                {
                    Console.WriteLine("Error writing app settings");
                }
            }

            else
            {
                //Enable all edit boxes.
                txtBox_ReportTo.Enabled = true;
                txtBox_Chekin.Enabled = true;
                txtBox_Chekout.Enabled = true;
                lunchLength.Enabled = true;
                btn_editReport.Text = "Save";
            }
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            //Send email check in notification.
            sendMessage(ConfigurationManager.AppSettings["checkin"]);
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {
            //Send lunch check in/out notification and start countdown.
            if (btn_lunch.Text == "Take Lunch")
            {
                lunchEndsAt = DateTime.Now + lunchDuration;
                lbl_lunchCountdown.Text = getTimeLeft(lunchEndsAt);

                lbl_Time.Font = new Font("Microsoft Sans Serif", 15);
                lbl_Time.Location = new System.Drawing.Point(65, 3);
                lbl_lunchCountdown.Visible = true;

                sendMessage(ConfigurationManager.AppSettings["checkout"]);
                btn_lunch.Text = "End Lunch";
            }
            else
            {
                lbl_Time.Font = new Font("Microsoft Sans Serif", 30);
                lbl_Time.Location = new System.Drawing.Point(6, 19);
                lbl_lunchCountdown.Visible = false;

                sendMessage(ConfigurationManager.AppSettings["checkin"]);
                btn_lunch.Text = "Take Lunch";
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            //Send email check out notification.
            sendMessage(ConfigurationManager.AppSettings["checkout"]);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            log();
        }
    
        private void chkBox_saveInfo_Click(object sender, EventArgs e)
        {
            if (chkBox_saveInfo.Checked == true)
            {
                DialogResult res = MessageBox.Show("This program currently has NO security!\n" +
                    "If you save your password, it will be saved on the local computer. " +
                    "Anyone with access to this computer who knows what to do will be able to retrieve the password. " +
                    "We recommend you leave this box unchecked.\nAre you sure you would like to save your password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                {
                    chkBox_saveInfo.Checked = false;
                }
            }

            // When the box gets unchecked, immediately wipe out the password.
            else
            {
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    settings["password"].Value = "";
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                    txtBox_pw.Text = "";
                }
                catch (ConfigurationErrorsException)
                {
                    Console.WriteLine("Error writing app settings");
                }
            }
        }

        private string getTimeLeft(DateTime lunchEnd)
        {
            TimeSpan timeleft = lunchEnd - DateTime.Now;
            
            string minutes = ((timeleft.Hours * 60) + timeleft.Minutes).ToString();
            if (minutes.Length < 2) { minutes = "0" + minutes; }
            string seconds = timeleft.Seconds.ToString();
            if (seconds.Length < 2) { seconds = "0" + seconds; }

            return minutes + ":" + seconds;
        }

        private void sendMessage(string msg)
        {

            try
            {
                MailAddress address = new MailAddress(txtBox_email.Text);
                string hst = ConfigurationManager.AppSettings[address.Host];
                string host = hst.Split('|')[0];
                int port = Convert.ToInt32(hst.Split('|')[1]);

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(host);

                mail.From = new MailAddress(address.ToString());
                mail.To.Add(txtBox_ReportTo.Text);
                mail.Subject = "Time  Report"; // ---------------------------------------TODO: Determine subject line.------------------
                mail.Body = msg;

                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(address.ToString(), txtBox_pw.Text);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent - " + mail.Body);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void log()
        {
            if (btn_login.Text == "Lock In")
            {
                txtBox_email.Enabled = false;
                txtBox_pw.Enabled = false;
                btn_login.Text = "Unlock";
                this.Text = txtBox_email.Text;
                btn_checkin.Enabled = true;
                btn_lunch.Enabled = true;
                btn_checkout.Enabled = true;
                chkBox_saveInfo.Enabled = true;

                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    settings["email"].Value = txtBox_email.Text;
                    if (chkBox_saveInfo.Checked == true) { settings["password"].Value = txtBox_pw.Text; }
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                }
                catch (ConfigurationErrorsException)
                {
                    Console.WriteLine("Error writing app settings");
                }

            }

            else
            {
                txtBox_email.Enabled = true;
                txtBox_pw.Enabled = true;
                if (chkBox_saveInfo.Checked == false) { txtBox_pw.Text = ""; }
                btn_login.Text = "Lock In";
                this.Text = "Enter email info";
                btn_checkin.Enabled = false;
                btn_lunch.Enabled = false;
                btn_checkout.Enabled = false;
                chkBox_saveInfo.Enabled = false;
            }
        }
    }
}