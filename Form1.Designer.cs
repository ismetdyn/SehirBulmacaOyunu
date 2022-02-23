
namespace Proje5._35SehirBulmacaOyunu
{
    partial class Form1
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
            this.pnlSehirAdi = new System.Windows.Forms.Panel();
            this.tbHarf = new System.Windows.Forms.TextBox();
            this.tbTahmin = new System.Windows.Forms.TextBox();
            this.btnHarf = new System.Windows.Forms.Button();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lAktifHarfPuani = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lToplamPuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lGirilenHarfler = new System.Windows.Forms.Label();
            this.lKalanHakSayisi = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlSehirAdi
            // 
            this.pnlSehirAdi.Location = new System.Drawing.Point(29, 38);
            this.pnlSehirAdi.Name = "pnlSehirAdi";
            this.pnlSehirAdi.Size = new System.Drawing.Size(445, 100);
            this.pnlSehirAdi.TabIndex = 0;
            // 
            // tbHarf
            // 
            this.tbHarf.Location = new System.Drawing.Point(481, 38);
            this.tbHarf.Name = "tbHarf";
            this.tbHarf.Size = new System.Drawing.Size(242, 22);
            this.tbHarf.TabIndex = 1;
            // 
            // tbTahmin
            // 
            this.tbTahmin.Location = new System.Drawing.Point(481, 94);
            this.tbTahmin.Name = "tbTahmin";
            this.tbTahmin.Size = new System.Drawing.Size(242, 22);
            this.tbTahmin.TabIndex = 2;
            // 
            // btnHarf
            // 
            this.btnHarf.Location = new System.Drawing.Point(742, 25);
            this.btnHarf.Name = "btnHarf";
            this.btnHarf.Size = new System.Drawing.Size(96, 35);
            this.btnHarf.TabIndex = 3;
            this.btnHarf.Text = "Harf";
            this.btnHarf.UseVisualStyleBackColor = true;
            this.btnHarf.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(742, 83);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(96, 33);
            this.btnTahmin.TabIndex = 4;
            this.btnTahmin.Text = "Tahmin";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(-2, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 23);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aktif Harf Puanı:";
            // 
            // lAktifHarfPuani
            // 
            this.lAktifHarfPuani.AutoSize = true;
            this.lAktifHarfPuani.Location = new System.Drawing.Point(118, 221);
            this.lAktifHarfPuani.Name = "lAktifHarfPuani";
            this.lAktifHarfPuani.Size = new System.Drawing.Size(14, 16);
            this.lAktifHarfPuani.TabIndex = 7;
            this.lAktifHarfPuani.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toplam Puan:";
            // 
            // lToplamPuan
            // 
            this.lToplamPuan.AutoSize = true;
            this.lToplamPuan.Location = new System.Drawing.Point(118, 265);
            this.lToplamPuan.Name = "lToplamPuan";
            this.lToplamPuan.Size = new System.Drawing.Size(14, 16);
            this.lToplamPuan.TabIndex = 9;
            this.lToplamPuan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Girilen Harfler:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kalan Hak:";
            // 
            // lGirilenHarfler
            // 
            this.lGirilenHarfler.AutoSize = true;
            this.lGirilenHarfler.Location = new System.Drawing.Point(429, 221);
            this.lGirilenHarfler.Name = "lGirilenHarfler";
            this.lGirilenHarfler.Size = new System.Drawing.Size(11, 16);
            this.lGirilenHarfler.TabIndex = 12;
            this.lGirilenHarfler.Text = "-";
            // 
            // lKalanHakSayisi
            // 
            this.lKalanHakSayisi.AutoSize = true;
            this.lKalanHakSayisi.Location = new System.Drawing.Point(429, 265);
            this.lKalanHakSayisi.Name = "lKalanHakSayisi";
            this.lKalanHakSayisi.Size = new System.Drawing.Size(11, 16);
            this.lKalanHakSayisi.TabIndex = 13;
            this.lKalanHakSayisi.Text = "-";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(742, 221);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(96, 33);
            this.btnBaslat.TabIndex = 14;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 313);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lKalanHakSayisi);
            this.Controls.Add(this.lGirilenHarfler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lToplamPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lAktifHarfPuani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.btnHarf);
            this.Controls.Add(this.tbTahmin);
            this.Controls.Add(this.tbHarf);
            this.Controls.Add(this.pnlSehirAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSehirAdi;
        private System.Windows.Forms.TextBox tbHarf;
        private System.Windows.Forms.TextBox tbTahmin;
        private System.Windows.Forms.Button btnHarf;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lAktifHarfPuani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lToplamPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lGirilenHarfler;
        private System.Windows.Forms.Label lKalanHakSayisi;
        private System.Windows.Forms.Button btnBaslat;
    }
}

