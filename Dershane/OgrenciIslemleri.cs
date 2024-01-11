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
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }
        int button = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OgrenciKayit ogrenciKayit = new OgrenciKayit();
            ogrenciKayit.TopLevel = false;
            panel2.Controls.Add(ogrenciKayit);
            ogrenciKayit.Show();
            ogrenciKayit.Dock = DockStyle.Fill;
            ogrenciKayit.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OgrenciBilgi ogrenciBilgi = new OgrenciBilgi();
            ogrenciBilgi.TopLevel = false;
            panel2.Controls.Add(ogrenciBilgi);
            ogrenciBilgi.Show();
            ogrenciBilgi.Dock = DockStyle.Fill;
            ogrenciBilgi.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
