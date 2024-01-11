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
    public partial class OgretmenIslemleri : Form
    {
        public OgretmenIslemleri()
        {
            InitializeComponent();
        }

        private void btnogrtmnkyt_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OgretmenKayit ogretmenKayit = new OgretmenKayit();
            ogretmenKayit.TopLevel = false;
            panel2.Controls.Add(ogretmenKayit);
            ogretmenKayit.Show();
            ogretmenKayit.Dock = DockStyle.Fill;
            ogretmenKayit.BringToFront();
        }

        private void btnogrtmnblg_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OgretmenBilgi ogretmenBilgi = new OgretmenBilgi();
            ogretmenBilgi.TopLevel = false;
            panel2.Controls.Add(ogretmenBilgi);
            ogretmenBilgi.Show();
            ogretmenBilgi.Dock = DockStyle.Fill;
            ogretmenBilgi.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
