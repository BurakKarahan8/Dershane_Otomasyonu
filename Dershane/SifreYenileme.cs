using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane
{
    public partial class SifreYenileme : Form
    {
        public SifreYenileme()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("LÜTFEN DEĞER GİRİNİZ !!!");
            }
            else
            {
                if(textBox1.Text.Length<7 && textBox1.Text.Length > 5)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DershaneGiris.accdb");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("update Giris set Sifre=@sifre where ID=1", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("ŞİFRENİZ GÜNCELLENDİ...");
                    baglanti.Close();
                    AnaGiris anaGiris= new AnaGiris();
                    anaGiris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen 6 karakterden oluşan bir sayı şifresi giriniz !!!");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MailGonderme mailGonderme = new MailGonderme();
            mailGonderme.Show();
            this.Hide();
        }
    }
}
