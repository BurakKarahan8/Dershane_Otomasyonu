using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane
{
    public partial class MailGonderme : Form
    {
        public MailGonderme()
        {
            InitializeComponent();
        }

        String mailAdresim = "csharpburakkarahan@hotmail.com";
        String sifrem = "123456c#";

        private void MailGonderme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String msg = Convert.ToString(rnd.Next(1000, 9999));
            if (mailAdresim == txtMailInput.Text)
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(mailAdresim, sifrem);
                client.Port = 587;
                client.Host = "smtp.outlook.com";
                client.EnableSsl = true;
                message.To.Add(mailAdresim);
                message.From = new MailAddress(mailAdresim);
                message.Subject = "One-time password";
                message.Body = msg;
                client.Send(message);
                MailKarsilastirma mailKarsilastirma= new MailKarsilastirma(msg);
                MessageBox.Show("kodu gönderdik !");
                mailKarsilastirma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz e-posta hatalı, YENİDEN DENEYİN...");
                txtMailInput.Clear();
                txtMailInput.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
            this.Hide();
        }
    }
}
