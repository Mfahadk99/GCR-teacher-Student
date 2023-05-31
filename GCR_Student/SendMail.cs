using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace GCR_Student
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }
        MailMessage mm = new MailMessage();

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (txt_body.Text != "" && txt_Subject.Text != "" && txt_to.Text != "") {
                try
                {
                    SmtpClient sm = new SmtpClient("smtp.gmail.com");
                    mm.To.Add(txt_to.Text);
                    mm.From = new MailAddress("fahadk123572@gmail.com");
                    mm.Subject = txt_Subject.Text;
                    mm.Body = txt_body.Text;
                    sm.Port = 587;
                    sm.Credentials = new System.Net.NetworkCredential("fahadk123572@gmail.com", "zyajuwzrngojrywb");
                    sm.EnableSsl = true;
                    sm.Send(mm);

                    MessageBox.Show("Mail Sent");
                    txt_body.Text = "";
                    txt_Subject.Text = "";
                    txt_to.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Provide All Details!");
            }
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            StudentPanel sp = new StudentPanel();
            this.Hide();
            sp.Show();
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
