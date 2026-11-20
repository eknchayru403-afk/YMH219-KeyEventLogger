namespace YMH219_KeyEventLogger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDurum = new Label();
            lblIstatistik = new Label();
            btnBaslat = new Button();
            btnDurdur = new Button();
            btnTemizle = new Button();
            btnKaydet = new Button();
            lstKayitlar = new ListBox();
            SuspendLayout();
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(38, 29);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(179, 20);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "Durum: Beklemede (Pasif)";
            // 
            // lblIstatistik
            // 
            lblIstatistik.AutoSize = true;
            lblIstatistik.Location = new Point(38, 68);
            lblIstatistik.Name = "lblIstatistik";
            lblIstatistik.Size = new Size(151, 20);
            lblIstatistik.TabIndex = 1;
            lblIstatistik.Text = "Toplam Basılan Tuş: 0";
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(51, 135);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(94, 29);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnDurdur
            // 
            btnDurdur.Enabled = false;
            btnDurdur.Location = new Point(177, 135);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(94, 29);
            btnDurdur.TabIndex = 3;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(303, 135);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(434, 135);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Dosyaya Kaydet (.txt)";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstKayitlar
            // 
            lstKayitlar.FormattingEnabled = true;
            lstKayitlar.Location = new Point(2, 181);
            lstKayitlar.Name = "lstKayitlar";
            lstKayitlar.Size = new Size(798, 264);
            lstKayitlar.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKayitlar);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Controls.Add(lblIstatistik);
            Controls.Add(lblDurum);
            KeyPreview = true;
            Name = "Form1";
            Text = "Key Event Logger - YMH 219";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDurum;
        private Label lblIstatistik;
        private Button btnBaslat;
        private Button btnDurdur;
        private Button btnTemizle;
        private Button btnKaydet;
        private ListBox lstKayitlar;
    }
}
