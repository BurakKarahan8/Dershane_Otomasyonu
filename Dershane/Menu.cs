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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaGiris anaGiris = new AnaGiris();
            anaGiris.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
            ogrenciIslemleri.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgretmenIslemleri ogretmenIslemleri = new OgretmenIslemleri();
            ogretmenIslemleri.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinansalIslemler finansalIslemler = new FinansalIslemler();
            finansalIslemler.Show();
            this.Hide();
        }

        private void btn_Sinif_Click(object sender, EventArgs e)
        {
            Sinif sinif = new Sinif();
            sinif.Show();
            this.Hide();
        }
    }
}
