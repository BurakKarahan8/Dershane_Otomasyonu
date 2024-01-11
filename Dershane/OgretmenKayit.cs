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
    public partial class OgretmenKayit : Form
    {
        public OgretmenKayit()
        {
            InitializeComponent();
        }

        

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (adtxt.Text == "" || soyadtxt.Text == "" || branstxt.Text == "" || telnotxt.Text == "")
            {
                MessageBox.Show("Lütfen boş değer bırakmayınız !!!");
            }
            else
            {
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DershaneOgretmen.accdb");
                connection.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO Ogretmenler (Ad,Soyad,Brans,TelNo) VALUES (@p1,@p2,@p3,@p4)", connection);
                komut.Parameters.AddWithValue("@p1", adtxt.Text);
                komut.Parameters.AddWithValue("@p2", soyadtxt.Text);
                komut.Parameters.AddWithValue("@p3", branstxt.Text);
                komut.Parameters.AddWithValue("@p4", telnotxt.Text);
                
                komut.ExecuteNonQuery();
                connection.Close();

                adtxt.Clear();
                soyadtxt.Clear();
                branstxt.Clear();
                telnotxt.Clear();
                MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
            }
        }

        private void daltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
