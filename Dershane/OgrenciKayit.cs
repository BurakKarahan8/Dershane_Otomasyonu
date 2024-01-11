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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adtxt.Text == "" || soyadtxt.Text == "" || sınıftxt.Text == "" || daltxt.Text == ""  || telNoTxt.Text == "" || veliteltxt.Text == "")
            {
                MessageBox.Show("Lütfen boş değer bırakmayınız !!!");
            }
            else
            {
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
                connection.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO Ogrenciler (Ad,Soyad,Sinif,Dal,DogumTarihi,TelNo,VeliTelNo) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                komut.Parameters.AddWithValue("@p1", adtxt.Text);
                komut.Parameters.AddWithValue("@p2", soyadtxt.Text);
                komut.Parameters.AddWithValue("@p3", sınıftxt.Text);
                komut.Parameters.AddWithValue("@p4", daltxt.Text);
                komut.Parameters.AddWithValue("@p5", dateTime_dogum.Value.ToString("dd/MM/yyyy"));
                komut.Parameters.AddWithValue("@p6", telNoTxt.Text);
                komut.Parameters.AddWithValue("@p7", veliteltxt.Text);
                komut.ExecuteNonQuery();
                connection.Close();

                adtxt.Clear();
                soyadtxt.Clear();
                sınıftxt.Clear();
                telNoTxt.Clear();
                veliteltxt.Clear();

                MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
            }

        }

        private void adtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void veliteltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void veliteltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
