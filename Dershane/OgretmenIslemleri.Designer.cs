namespace Dershane
{
    partial class OgretmenIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnogrtmnblg = new System.Windows.Forms.Button();
            this.btnogrtmnkyt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnogrtmnblg);
            this.panel1.Controls.Add(this.btnogrtmnkyt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnogrtmnblg
            // 
            this.btnogrtmnblg.BackColor = System.Drawing.Color.DarkOrange;
            this.btnogrtmnblg.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnogrtmnblg.FlatAppearance.BorderSize = 3;
            this.btnogrtmnblg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogrtmnblg.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnogrtmnblg.Location = new System.Drawing.Point(12, 307);
            this.btnogrtmnblg.Name = "btnogrtmnblg";
            this.btnogrtmnblg.Size = new System.Drawing.Size(145, 68);
            this.btnogrtmnblg.TabIndex = 3;
            this.btnogrtmnblg.Text = "Öğretmen Bilgi";
            this.btnogrtmnblg.UseVisualStyleBackColor = false;
            this.btnogrtmnblg.Click += new System.EventHandler(this.btnogrtmnblg_Click);
            // 
            // btnogrtmnkyt
            // 
            this.btnogrtmnkyt.BackColor = System.Drawing.Color.DarkOrange;
            this.btnogrtmnkyt.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnogrtmnkyt.FlatAppearance.BorderSize = 3;
            this.btnogrtmnkyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogrtmnkyt.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnogrtmnkyt.Location = new System.Drawing.Point(12, 194);
            this.btnogrtmnkyt.Name = "btnogrtmnkyt";
            this.btnogrtmnkyt.Size = new System.Drawing.Size(145, 68);
            this.btnogrtmnkyt.TabIndex = 2;
            this.btnogrtmnkyt.Text = "Öğretmen Kayıt";
            this.btnogrtmnkyt.UseVisualStyleBackColor = false;
            this.btnogrtmnkyt.Click += new System.EventHandler(this.btnogrtmnkyt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(175, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 537);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OgretmenIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgretmenIslemleri";
            this.Text = "OgretmenIslemleri";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnogrtmnblg;
        private System.Windows.Forms.Button btnogrtmnkyt;
        private System.Windows.Forms.Button button1;
    }
}