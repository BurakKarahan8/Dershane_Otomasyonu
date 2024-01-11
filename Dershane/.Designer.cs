namespace Dershane
{
    partial class AnaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            this.baslık = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KullaniciID = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisbutonu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslık
            // 
            this.baslık.AutoSize = true;
            this.baslık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.baslık.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.baslık.ForeColor = System.Drawing.Color.Black;
            this.baslık.Location = new System.Drawing.Point(324, 75);
            this.baslık.Name = "baslık";
            this.baslık.Size = new System.Drawing.Size(368, 39);
            this.baslık.TabIndex = 0;
            this.baslık.Text = "DERSHANE OTOMASYONU";
            this.baslık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciID
            // 
            this.KullaniciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciID.Location = new System.Drawing.Point(484, 254);
            this.KullaniciID.Multiline = true;
            this.KullaniciID.Name = "KullaniciID";
            this.KullaniciID.Size = new System.Drawing.Size(208, 33);
            this.KullaniciID.TabIndex = 2;
            this.KullaniciID.Text = "1";
            this.KullaniciID.TextChanged += new System.EventHandler(this.KullaniciID_TextChanged);
            // 
            // Sifre
            // 
            this.Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre.Location = new System.Drawing.Point(484, 333);
            this.Sifre.Multiline = true;
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(208, 33);
            this.Sifre.TabIndex = 3;
            this.Sifre.Text = "123456";
            this.Sifre.TextChanged += new System.EventHandler(this.Sifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(325, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(325, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "       Şifre      :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // girisbutonu
            // 
            this.girisbutonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.girisbutonu.FlatAppearance.BorderSize = 0;
            this.girisbutonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisbutonu.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutonu.ForeColor = System.Drawing.Color.White;
            this.girisbutonu.Location = new System.Drawing.Point(497, 418);
            this.girisbutonu.Name = "girisbutonu";
            this.girisbutonu.Size = new System.Drawing.Size(174, 64);
            this.girisbutonu.TabIndex = 6;
            this.girisbutonu.Text = "GİRİŞ";
            this.girisbutonu.UseVisualStyleBackColor = false;
            this.girisbutonu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(327, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifremi Unuttum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisbutonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.baslık);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaGiris";
            this.Text = "Ana Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslık;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox KullaniciID;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisbutonu;
        private System.Windows.Forms.Label label3;
    }
}

