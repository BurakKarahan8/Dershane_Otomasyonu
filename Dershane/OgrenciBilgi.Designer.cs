namespace Dershane
{
    partial class OgrenciBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciBilgi));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sınıf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VeliTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.veliteltxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sınıftxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telNoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerileriGoster = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.notxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.silinecekNoTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime_dogum = new System.Windows.Forms.DateTimePicker();
            this.daltxt = new System.Windows.Forms.ComboBox();
            this.progressBar_ogrenci = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_doluluk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(337, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ BİLGİ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numara,
            this.Ad,
            this.Soyad,
            this.Sınıf,
            this.Dal,
            this.TelNo,
            this.VeliTel,
            this.DogumTarihi,
            this.Ucret});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(283, 216);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(546, 312);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Numara
            // 
            this.Numara.Text = "NO";
            this.Numara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numara.Width = 30;
            // 
            // Ad
            // 
            this.Ad.Text = "AD";
            this.Ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ad.Width = 70;
            // 
            // Soyad
            // 
            this.Soyad.Text = "SOYAD";
            this.Soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Soyad.Width = 70;
            // 
            // Sınıf
            // 
            this.Sınıf.Text = "SINIF";
            this.Sınıf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sınıf.Width = 40;
            // 
            // Dal
            // 
            this.Dal.Text = "DAL";
            this.Dal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dal.Width = 35;
            // 
            // TelNo
            // 
            this.TelNo.Text = "TELEFON";
            this.TelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TelNo.Width = 80;
            // 
            // VeliTel
            // 
            this.VeliTel.Text = "VELİ TELEFON";
            this.VeliTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VeliTel.Width = 87;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.Text = "D. TARİHİ";
            this.DogumTarihi.Width = 70;
            // 
            // Ucret
            // 
            this.Ucret.Text = "ÜCRET";
            this.Ucret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // veliteltxt
            // 
            this.veliteltxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliteltxt.Location = new System.Drawing.Point(115, 305);
            this.veliteltxt.Multiline = true;
            this.veliteltxt.Name = "veliteltxt";
            this.veliteltxt.Size = new System.Drawing.Size(145, 24);
            this.veliteltxt.TabIndex = 28;
            this.veliteltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.veliteltxt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "VELİ TEL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(49, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "DAL :";
            // 
            // sınıftxt
            // 
            this.sınıftxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sınıftxt.Location = new System.Drawing.Point(115, 153);
            this.sınıftxt.Multiline = true;
            this.sınıftxt.Name = "sınıftxt";
            this.sınıftxt.Size = new System.Drawing.Size(145, 24);
            this.sınıftxt.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(41, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "SINIF :";
            // 
            // telNoTxt
            // 
            this.telNoTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNoTxt.Location = new System.Drawing.Point(115, 266);
            this.telNoTxt.Multiline = true;
            this.telNoTxt.Name = "telNoTxt";
            this.telNoTxt.Size = new System.Drawing.Size(145, 24);
            this.telNoTxt.TabIndex = 22;
            this.telNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telNoTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "TEL NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "D. TARİHİ :";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadtxt.Location = new System.Drawing.Point(115, 116);
            this.soyadtxt.Multiline = true;
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(145, 24);
            this.soyadtxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "SOYAD :";
            // 
            // adtxt
            // 
            this.adtxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtxt.Location = new System.Drawing.Point(115, 79);
            this.adtxt.Multiline = true;
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(145, 24);
            this.adtxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "AD :";
            // 
            // btnVerileriGoster
            // 
            this.btnVerileriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerileriGoster.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVerileriGoster.FlatAppearance.BorderSize = 3;
            this.btnVerileriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerileriGoster.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnVerileriGoster.Location = new System.Drawing.Point(364, 148);
            this.btnVerileriGoster.Name = "btnVerileriGoster";
            this.btnVerileriGoster.Size = new System.Drawing.Size(165, 41);
            this.btnVerileriGoster.TabIndex = 29;
            this.btnVerileriGoster.Text = "Verileri Göster !";
            this.btnVerileriGoster.UseVisualStyleBackColor = false;
            this.btnVerileriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuncelle.FlatAppearance.BorderSize = 3;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuncelle.Location = new System.Drawing.Point(62, 365);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 41);
            this.btnGuncelle.TabIndex = 30;
            this.btnGuncelle.Text = "Güncelle !";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // notxt
            // 
            this.notxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notxt.Location = new System.Drawing.Point(115, 41);
            this.notxt.Multiline = true;
            this.notxt.Name = "notxt";
            this.notxt.Size = new System.Drawing.Size(145, 24);
            this.notxt.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(55, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "NO :";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatAppearance.BorderSize = 3;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(30, 116);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(165, 41);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "SİL !";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // silinecekNoTxt
            // 
            this.silinecekNoTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silinecekNoTxt.Location = new System.Drawing.Point(30, 71);
            this.silinecekNoTxt.Multiline = true;
            this.silinecekNoTxt.Name = "silinecekNoTxt";
            this.silinecekNoTxt.Size = new System.Drawing.Size(165, 24);
            this.silinecekNoTxt.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(45, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "SİLİNECEK NO :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.dateTime_dogum);
            this.panel1.Controls.Add(this.daltxt);
            this.panel1.Controls.Add(this.progressBar_ogrenci);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.notxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.veliteltxt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_doluluk);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.sınıftxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.telNoTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.soyadtxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adtxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 537);
            this.panel1.TabIndex = 37;
            // 
            // dateTime_dogum
            // 
            this.dateTime_dogum.Location = new System.Drawing.Point(115, 231);
            this.dateTime_dogum.Name = "dateTime_dogum";
            this.dateTime_dogum.Size = new System.Drawing.Size(145, 20);
            this.dateTime_dogum.TabIndex = 37;
            // 
            // daltxt
            // 
            this.daltxt.BackColor = System.Drawing.Color.White;
            this.daltxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daltxt.FormattingEnabled = true;
            this.daltxt.Items.AddRange(new object[] {
            "MF",
            "TM",
            "SÖZEL"});
            this.daltxt.Location = new System.Drawing.Point(115, 193);
            this.daltxt.Name = "daltxt";
            this.daltxt.Size = new System.Drawing.Size(145, 21);
            this.daltxt.TabIndex = 36;
            // 
            // progressBar_ogrenci
            // 
            this.progressBar_ogrenci.Location = new System.Drawing.Point(45, 463);
            this.progressBar_ogrenci.Maximum = 50;
            this.progressBar_ogrenci.Name = "progressBar_ogrenci";
            this.progressBar_ogrenci.Size = new System.Drawing.Size(191, 26);
            this.progressBar_ogrenci.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(5, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "D. TARİHİ :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(5, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "DOLULUK ORANI: ";
            // 
            // lbl_doluluk
            // 
            this.lbl_doluluk.AutoSize = true;
            this.lbl_doluluk.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_doluluk.Location = new System.Drawing.Point(194, 504);
            this.lbl_doluluk.Name = "lbl_doluluk";
            this.lbl_doluluk.Size = new System.Drawing.Size(20, 24);
            this.lbl_doluluk.TabIndex = 27;
            this.lbl_doluluk.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.silinecekNoTxt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 179);
            this.panel2.TabIndex = 38;
            // 
            // OgrenciBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(837, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerileriGoster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciBilgi";
            this.Text = "OgrenciBilgi";
            this.Load += new System.EventHandler(this.OgrenciBilgi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Sınıf;
        private System.Windows.Forms.ColumnHeader Dal;
        private System.Windows.Forms.ColumnHeader TelNo;
        private System.Windows.Forms.ColumnHeader Numara;
        private System.Windows.Forms.ColumnHeader VeliTel;
        private System.Windows.Forms.ColumnHeader Ucret;
        private System.Windows.Forms.TextBox veliteltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sınıftxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telNoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerileriGoster;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox notxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox silinecekNoTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader DogumTarihi;
        private System.Windows.Forms.ProgressBar progressBar_ogrenci;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_doluluk;
        private System.Windows.Forms.ComboBox daltxt;
        private System.Windows.Forms.DateTimePicker dateTime_dogum;
    }
}