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
    public partial class OgrenciFinansi : Form
    {
        public OgrenciFinansi()
        {
            InitializeComponent();
        }

        int ogrenci_no;

        private void notxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (notxt.Text == "")
            {
                MessageBox.Show("LÜTFEN BİR DEĞER GİRİNİZ !!!");
            }
            else
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from ogrenciler where OgrenciNo=@no", baglanti);
                komut.Parameters.AddWithValue("@no", notxt.Text);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    int.TryParse(notxt.Text, out ogrenci_no);

                    panel1.Controls.Clear();
                    OgrenciFinansIslem ogrenciFinansIslem = new OgrenciFinansIslem(ogrenci_no);
                    ogrenciFinansIslem.TopLevel = false;
                    panel1.Controls.Add(ogrenciFinansIslem);
                    ogrenciFinansIslem.Show();
                    ogrenciFinansIslem.Dock = DockStyle.Fill;
                    ogrenciFinansIslem.BringToFront();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş denemesi...");
                }

                baglanti.Close();
            }       
        }

        private void OgrenciFinansi_Load(object sender, EventArgs e)
        {

        }
    }
}
