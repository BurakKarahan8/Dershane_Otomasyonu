namespace Dershane
{
    partial class Sinif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinif));
            this.pnl_buton = new System.Windows.Forms.Panel();
            this.btn_esitAgirlik = new System.Windows.Forms.Button();
            this.btn_sozel = new System.Windows.Forms.Button();
            this.btn_sayısal = new System.Windows.Forms.Button();
            this.datagrid_sinif = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.pnl_buton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sinif)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_buton
            // 
            this.pnl_buton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_buton.Controls.Add(this.btn_geri);
            this.pnl_buton.Controls.Add(this.btn_esitAgirlik);
            this.pnl_buton.Controls.Add(this.btn_sozel);
            this.pnl_buton.Controls.Add(this.btn_sayısal);
            this.pnl_buton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_buton.Location = new System.Drawing.Point(0, 0);
            this.pnl_buton.Name = "pnl_buton";
            this.pnl_buton.Size = new System.Drawing.Size(200, 561);
            this.pnl_buton.TabIndex = 0;
            // 
            // btn_esitAgirlik
            // 
            this.btn_esitAgirlik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_esitAgirlik.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_esitAgirlik.FlatAppearance.BorderSize = 4;
            this.btn_esitAgirlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esitAgirlik.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_esitAgirlik.Location = new System.Drawing.Point(19, 385);
            this.btn_esitAgirlik.Name = "btn_esitAgirlik";
            this.btn_esitAgirlik.Size = new System.Drawing.Size(154, 85);
            this.btn_esitAgirlik.TabIndex = 0;
            this.btn_esitAgirlik.Text = "EŞİT AĞIRLIK";
            this.btn_esitAgirlik.UseVisualStyleBackColor = false;
            this.btn_esitAgirlik.Click += new System.EventHandler(this.btn_esitAgirlik_Click);
            // 
            // btn_sozel
            // 
            this.btn_sozel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sozel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sozel.FlatAppearance.BorderSize = 4;
            this.btn_sozel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sozel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_sozel.Location = new System.Drawing.Point(19, 234);
            this.btn_sozel.Name = "btn_sozel";
            this.btn_sozel.Size = new System.Drawing.Size(154, 85);
            this.btn_sozel.TabIndex = 0;
            this.btn_sozel.Text = "SÖZEL";
            this.btn_sozel.UseVisualStyleBackColor = false;
            this.btn_sozel.Click += new System.EventHandler(this.btn_sozel_Click);
            // 
            // btn_sayısal
            // 
            this.btn_sayısal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sayısal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sayısal.FlatAppearance.BorderSize = 4;
            this.btn_sayısal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sayısal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sayısal.Location = new System.Drawing.Point(19, 88);
            this.btn_sayısal.Name = "btn_sayısal";
            this.btn_sayısal.Size = new System.Drawing.Size(154, 85);
            this.btn_sayısal.TabIndex = 0;
            this.btn_sayısal.Text = "SAYISAL";
            this.btn_sayısal.UseVisualStyleBackColor = false;
            this.btn_sayısal.Click += new System.EventHandler(this.btn_sayısal_Click);
            // 
            // datagrid_sinif
            // 
            this.datagrid_sinif.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_sinif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_sinif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_sinif.Location = new System.Drawing.Point(200, 0);
            this.datagrid_sinif.Name = "datagrid_sinif";
            this.datagrid_sinif.Size = new System.Drawing.Size(824, 561);
            this.datagrid_sinif.TabIndex = 1;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_geri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_geri.FlatAppearance.BorderSize = 4;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(19, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(154, 45);
            this.btn_geri.TabIndex = 1;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Sinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.datagrid_sinif);
            this.Controls.Add(this.pnl_buton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sinif";
            this.Text = "Sinif";
            this.Load += new System.EventHandler(this.Sinif_Load);
            this.pnl_buton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sinif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_buton;
        private System.Windows.Forms.Button btn_esitAgirlik;
        private System.Windows.Forms.Button btn_sozel;
        private System.Windows.Forms.Button btn_sayısal;
        private System.Windows.Forms.DataGridView datagrid_sinif;
        private System.Windows.Forms.Button btn_geri;
    }
}