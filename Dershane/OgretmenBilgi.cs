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
    public partial class OgretmenBilgi : Form
    {
        public OgretmenBilgi()
        {
            InitializeComponent();
        }

        private void verileriGoster()
        {
            listView1.Items.Clear();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DershaneOgretmen.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Ogretmenler", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OgretmenNo"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Brans"].ToString());
                ekle.SubItems.Add(oku["TelNo"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (notxt.Text == "" || adtxt.Text == "" || soyadtxt.Text == "" || branstxt.Text == "" || telnotxt.Text == "")
            {
                MessageBox.Show("Lütfen boş değer bırakmayınız !!!");
            }
            else
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("GÜNCELLEME İŞLEMİ YAPMAK İSTİYORMUSUNUZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sonuc == DialogResult.OK)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DershaneOgretmen.accdb");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("update Ogretmenler set Ad=@ad, Soyad=@soyad, Brans=@brans, TelNo=@telno where OgretmenNo=@no", baglanti);
                    komut.Parameters.AddWithValue("@ad", adtxt.Text);
                    komut.Parameters.AddWithValue("@soyad", soyadtxt.Text);
                    komut.Parameters.AddWithValue("@brans", branstxt.Text);
                    komut.Parameters.AddWithValue("telno",telnotxt.Text);
                    komut.Parameters.AddWithValue("@no", notxt.Text);
                    if(int.TryParse(notxt.Text, out int sayac))
                    {
                        sayac = komut.ExecuteNonQuery();
                        
                        if (sayac > 0)
                        {
                            MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI");
                            notxt.Clear();
                            adtxt.Clear();
                            soyadtxt.Clear();
                            branstxt.Clear();
                            telnotxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("GEÇERSİZ NUMARA GİRDİNİZ !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("GEÇERSİZ DEĞER GİRDİNİZ !!!");
                    }
                    baglanti.Close();
                }
                verileriGoster();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (silinecekNoTxt.Text == null || silinecekNoTxt.Text == "")
            {

                MessageBox.Show("silinecek değer giriniz");
            }
            else
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("SİLME İŞLEMİ YAPMAK İSTİYORMUSUNUZ ?", "SİLME İŞLEMİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sonuc == DialogResult.OK)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\DershaneOgretmen.accdb");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("delete from Ogretmenler where OgretmenNo = @no", baglanti);
                    komut.Parameters.AddWithValue("@no", silinecekNoTxt.Text);
                    if(int.TryParse(silinecekNoTxt.Text, out int sayac))
                    {
                        sayac = komut.ExecuteNonQuery();
                        
                        if (sayac > 0)
                        {
                            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                            silinecekNoTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("GEÇERSİZ NUMARA GİRDİNİZ !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("GEÇERSİZ DEĞER GİRDİNİZ !!!");
                    }
                    baglanti.Close();
                }
                verileriGoster();
            }
        }

        private void OgretmenBilgi_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void adtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void telnotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
