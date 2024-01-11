using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane
{
    public partial class MailKarsilastirma : Form
    {
        string kontrol;
        public MailKarsilastirma(string msg)
        {
            InitializeComponent();
            kontrol = msg;
        }

        private void MailKarsilastirma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kontrol)
            {
                MessageBox.Show("kodu doğru girdiniz !");
                SifreYenileme sifreYenileme = new SifreYenileme();
                sifreYenileme.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kodu yanlış girdiniz, tekrar mail göndermeye yönlendirildniz...");
                MailGonderme mailGonderme = new MailGonderme();
                mailGonderme.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MailGonderme mailGonderme2 = new MailGonderme();
            mailGonderme2.Show();
            this.Hide();
        }
    }
}
