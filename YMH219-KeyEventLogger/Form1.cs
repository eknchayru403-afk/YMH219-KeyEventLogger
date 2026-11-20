using System;
using System.Drawing;
using System.Windows.Forms;

namespace YMH219_KeyEventLogger
{
    public partial class Form1 : Form
    {
        private readonly KeyLoggerManager _logger = new KeyLoggerManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Sadece bu pencere odaktayken ve kayıt başlatılmışsa tuşu yakalar
            KeyLogEntry kayit = _logger.TusKaydet(e.KeyCode);

            if (kayit != null)
            {
                lstKayitlar.Items.Add(kayit.ToString());
                lstKayitlar.TopIndex = lstKayitlar.Items.Count - 1; // En son satıra kaydır
                lblIstatistik.Text = $"Toplam Basılan Tuş: {_logger.ToplamTusSayisi}";
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            _logger.Baslat();
            lblDurum.Text = "Durum: Kayıt Aktif (Dinleniyor...)";
            lblDurum.ForeColor = Color.DarkGreen;

            btnBaslat.Enabled = false;
            btnDurdur.Enabled = true;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            _logger.Durdur();
            lblDurum.Text = "Durum: Durduruldu (Pasif)";
            lblDurum.ForeColor = Color.DarkRed;

            btnBaslat.Enabled = true;
            btnDurdur.Enabled = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            _logger.Temizle();
            lstKayitlar.Items.Clear();
            lblIstatistik.Text = "Toplam Basılan Tuş: 0";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_logger.ToplamTusSayisi == 0)
            {
                MessageBox.Show("Kaydedilecek tuş kaydı bulunamadı. Önce kaydı başlatıp birkaç tuşa basın.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Metin Dosyası (*.txt)|*.txt";
                sfd.Title = "Tuş Kayıtlarını Kaydet";
                sfd.FileName = $"KeyLog_{DateTime.Now:yyyyMMdd_HHmm}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _logger.DosyayaKaydet(sfd.FileName);
                        MessageBox.Show("Kayıtlar başarıyla dosyaya aktarıldı.",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Dosya kaydedilirken hata oluştu: {ex.Message}",
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}