namespace Dershane
{
    partial class OgretmenBilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenBilgi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.notxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.telnotxt = new System.Windows.Forms.TextBox();
            this.branstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.silinecekNoTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerileriGoster = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.notxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.telnotxt);
            this.panel1.Controls.Add(this.branstxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.soyadtxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adtxt);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // notxt
            // 
            resources.ApplyResources(this.notxt, "notxt");
            this.notxt.Name = "notxt";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuncelle.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnGuncelle, "btnGuncelle");
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // telnotxt
            // 
            resources.ApplyResources(this.telnotxt, "telnotxt");
            this.telnotxt.Name = "telnotxt";
            this.telnotxt.TextChanged += new System.EventHandler(this.telnotxt_TextChanged);
            this.telnotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telnotxt_KeyPress);
            // 
            // branstxt
            // 
            resources.ApplyResources(this.branstxt, "branstxt");
            this.branstxt.Name = "branstxt";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // soyadtxt
            // 
            resources.ApplyResources(this.soyadtxt, "soyadtxt");
            this.soyadtxt.Name = "soyadtxt";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // adtxt
            // 
            resources.ApplyResources(this.adtxt, "adtxt");
            this.adtxt.Name = "adtxt";
            this.adtxt.TextChanged += new System.EventHandler(this.adtxt_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.silinecekNoTxt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnSil);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // silinecekNoTxt
            // 
            resources.ApplyResources(this.silinecekNoTxt, "silinecekNoTxt");
            this.silinecekNoTxt.Name = "silinecekNoTxt";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numara,
            this.Ad,
            this.Soyad,
            this.Brans,
            this.TelNo});
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Numara
            // 
            resources.ApplyResources(this.Numara, "Numara");
            // 
            // Ad
            // 
            resources.ApplyResources(this.Ad, "Ad");
            // 
            // Soyad
            // 
            resources.ApplyResources(this.Soyad, "Soyad");
            // 
            // Brans
            // 
            resources.ApplyResources(this.Brans, "Brans");
            // 
            // TelNo
            // 
            resources.ApplyResources(this.TelNo, "TelNo");
            // 
            // btnVerileriGoster
            // 
            this.btnVerileriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerileriGoster.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVerileriGoster.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnVerileriGoster, "btnVerileriGoster");
            this.btnVerileriGoster.Name = "btnVerileriGoster";
            this.btnVerileriGoster.UseVisualStyleBackColor = false;
            this.btnVerileriGoster.Click += new System.EventHandler(this.btnVerileriGoster_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // OgretmenBilgi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btnVerileriGoster);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenBilgi";
            this.Load += new System.EventHandler(this.OgretmenBilgi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox notxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox telnotxt;
        private System.Windows.Forms.TextBox branstxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox silinecekNoTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numara;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Brans;
        private System.Windows.Forms.ColumnHeader TelNo;
        private System.Windows.Forms.Button btnVerileriGoster;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}