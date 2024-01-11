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
    public partial class FinansalIslemler : Form
    {
        public FinansalIslemler()
        {
            InitializeComponent();
        }

        private void FinansalIslemler_Load(object sender, EventArgs e)
        {

        }

        private void btnogrncfnns_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            OgrenciFinansi ogrenciFinansi = new OgrenciFinansi();
            ogrenciFinansi.TopLevel = false;
            panel2.Controls.Add(ogrenciFinansi);
            ogrenciFinansi.Show();
            ogrenciFinansi.Dock = DockStyle.Fill;
            ogrenciFinansi.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
