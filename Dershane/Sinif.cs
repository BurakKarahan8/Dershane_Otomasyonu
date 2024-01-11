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
    public partial class Sinif : Form
    {
        public Sinif()
        {
            InitializeComponent();
        }

        private void Sinif_Load(object sender, EventArgs e)
        {
            OleDbConnection baglantı = new OleDbConnection(baglantiCumle);
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Ogrenciler",baglantı);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            datagrid_sinif.DataSource = dataTable;
            baglantı.Close();

        }
        string baglantiCumle = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb";
        void Listele(string dal)
        {
            OleDbConnection baglanti = new OleDbConnection(baglantiCumle);
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Ogrenciler WHERE Dal=@dal",baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@dal",dal);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid_sinif.DataSource = dt;
            baglanti.Close();
        }

        private void btn_sayısal_Click(object sender, EventArgs e)
        {
            Listele("MF");
        }

        private void btn_sozel_Click(object sender, EventArgs e)
        {
            Listele("SÖZEL");
        }

        private void btn_esitAgirlik_Click(object sender, EventArgs e)
        {
            Listele("TM");
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
                Menu menu = new Menu();
                menu.Show();
                this.Close();
        }
    }
}
