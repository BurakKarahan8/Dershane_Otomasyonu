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
    public partial class OgrenciBilgi : Form
    {
        public OgrenciBilgi()
        {
            InitializeComponent();
        }

        int kapasite = 50;
        void OgrenciTopla()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
            string sorgu = "SELECT COUNT(*) FROM Ogrenciler";
            OleDbCommand komut = new OleDbCommand(sorgu,baglanti);
            baglanti.Open();
            int toplam =(int)komut.ExecuteScalar();
            baglanti.Close();
            if (toplam>0)
            {
                progressBar_ogrenci.Value = toplam;
                int oran = (toplam * 100) / kapasite;
                lbl_doluluk.Text = "%" + oran;
            }
        }
        private void verileriGoster()
        {
            listView1.Items.Clear();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Ogrenciler", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OgrenciNo"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Sinif"].ToString());
                ekle.SubItems.Add(oku["Dal"].ToString());
                ekle.SubItems.Add(oku["TelNo"].ToString());
                ekle.SubItems.Add(oku["VeliTelNo"].ToString());
                ekle.SubItems.Add(oku["DogumTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (notxt.Text == "" || adtxt.Text == "" || soyadtxt.Text == "" || sınıftxt.Text == "" || daltxt.Text == "" || telNoTxt.Text == "" || veliteltxt.Text == "")
            {
                MessageBox.Show("Lütfen boş değer bırakmayınız !!!");
            }
            else
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("GÜNCELLEME İŞLEMİ YAPMAK İSTİYORMUSUNUZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sonuc == DialogResult.OK)
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("update Ogrenciler set Ad=@ad, Soyad=@soyad, Sinif=@sınıf, Dal=@dal, DogumTarihi=@dtarihi, TelNo=@telno, VeliTelNo=@velitelno where OgrenciNo=@no", baglanti);
                    komut.Parameters.AddWithValue("@ad", adtxt.Text);
                    komut.Parameters.AddWithValue("@soyad", soyadtxt.Text);
                    komut.Parameters.AddWithValue("@sınıf", sınıftxt.Text);
                    komut.Parameters.AddWithValue("@dal", daltxt.Text);
                    komut.Parameters.AddWithValue("@dtarihi",dateTime_dogum.Value.ToString("dd/MM/yyyy"));
                    komut.Parameters.AddWithValue("@telno", telNoTxt.Text);
                    komut.Parameters.AddWithValue("@velitelno", veliteltxt.Text);
                    komut.Parameters.AddWithValue("@no", notxt.Text);
                    if (int.TryParse(notxt.Text, out int sayac))
                    {
                        sayac = komut.ExecuteNonQuery();
                        
                        if (sayac > 0)
                        {
                            MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI");
                            notxt.Clear();
                            adtxt.Clear();
                            soyadtxt.Clear();
                            sınıftxt.Clear();
                            telNoTxt.Clear();
                            veliteltxt.Clear();
                            daltxt.Text = null;
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
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Ogrenciler.accdb");
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("delete from Ogrenciler where OgrenciNo = @no", baglanti);
                    komut.Parameters.AddWithValue("@no", silinecekNoTxt.Text);
                    if (int.TryParse(silinecekNoTxt.Text, out int sayac))
                    {
                        sayac = komut.ExecuteNonQuery();
                        
                        if (sayac > 0)
                        {
                            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                            silinecekNoTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("GEÇERSİZ NUMARA GİRDİNİZ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("GEÇERSİZ DEĞER GİRDİNİZ");
                    }
                    baglanti.Close();
                }
                verileriGoster();
            }
        }

        private void OgrenciBilgi_Load(object sender, EventArgs e)
        {
            OgrenciTopla();
            verileriGoster();
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
