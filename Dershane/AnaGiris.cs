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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dershane
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DershaneGiris.accdb");
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("Select * From Giris Where ID=@Id and Sifre=@sifre", baglanti);
            giris.Parameters.Add("Id", KullaniciID.Text);
            giris.Parameters.Add("sifre", Sifre.Text);

            OleDbDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                Menu menu1 = new Menu();
                menu1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş denemesi...");
            }
            baglanti.Close();
        }

        private void KullaniciID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MailGonderme mailGonderme = new MailGonderme();
            mailGonderme.Show();
            this.Hide();
        }
    }
}
