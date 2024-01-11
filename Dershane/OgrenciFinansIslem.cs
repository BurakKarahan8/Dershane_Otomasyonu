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
    public partial class OgrenciFinansIslem : Form
    {

        int ogrenci_no;

        public OgrenciFinansIslem(int ogrenci_no)
        {
            InitializeComponent();
            this.ogrenci_no = ogrenci_no;

            finansalBilgileriGetir(ogrenci_no);
        }
        private void finansalBilgileriGetir(int ogrenci_no)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select Ucret from Ogrenciler where OgrenciNo=@no", baglanti);
            komut.Parameters.AddWithValue("@no", ogrenci_no);
            object gecici = komut.ExecuteScalar();
            if(gecici != null && gecici != DBNull.Value)
            {
                int odenmis_tutar = Convert.ToInt32(gecici);
                int odenecek_tutar = 10000 - odenmis_tutar;
                lbl_odenmis_tutar.Text = odenmis_tutar.ToString();
                lbl_odenecek_tutar.Text = odenecek_tutar.ToString();

            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı...");
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int.TryParse(lbl_odenecek_tutar.Text, out int odenecek_tutar);

            if(tutartxt.Text == "")
            {
                MessageBox.Show("LÜTFEN BİR DEĞER GİRİNİZ !!!");
            }
            else
            {
                if(int.TryParse(tutartxt.Text, out int odeme_miktari))
                {
                    if(odenecek_tutar < odeme_miktari)
                    {
                        MessageBox.Show("FAZLA ÜCRET GİRDİNİZ !!!");
                    }
                    else if (odeme_miktari < 0)
                    {
                        MessageBox.Show("YANLIŞ DEĞER GİRDİNİZ !!!");
                    }
                    else
                    {
                        odenmisTutarGuncelle(ogrenci_no, odeme_miktari);
                        finansalBilgileriGetir(ogrenci_no);
                        tutartxt.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("YANLIŞ DEĞER GİRDİNİZ !!!");
                }
            }
        }

        private void odenmisTutarGuncelle(int ogrenci_no , int odeme_miktari)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Ogrenciler set Ucret=Ucret + @tutar where OgrenciNo=@no", baglanti);
            komut.Parameters.AddWithValue("@tutar", odeme_miktari);
            komut.Parameters.AddWithValue("@no", ogrenci_no);
            int sayac = komut.ExecuteNonQuery();
            if (sayac > 0)
            {
                MessageBox.Show("ÖDEME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ");
            }
            else
            {
                MessageBox.Show("Ödeme işlemi gerçekleştirilemedi...");
            }
        }

        private void OgrenciFinansIslem_Load(object sender, EventArgs e)
        {

        }

        private void notxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
