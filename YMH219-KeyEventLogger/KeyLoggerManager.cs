using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace YMH219_KeyEventLogger
{
    // Kayıt durumunu, listeyi ve dosya işlemlerini yöneten sınıf
    public class KeyLoggerManager
    {
        private readonly List<KeyLogEntry> _kayitlar = new List<KeyLogEntry>();

        public bool KayitAktifMi { get; private set; } = false;
        public int ToplamTusSayisi => _kayitlar.Count;

        public void Baslat()
        {
            KayitAktifMi = true;
        }

        public void Durdur()
        {
            KayitAktifMi = false;
        }

        public KeyLogEntry TusKaydet(Keys tus)
        {
            if (!KayitAktifMi)
                return null;

            var yeniKayit = new KeyLogEntry(tus.ToString());
            _kayitlar.Add(yeniKayit);
            return yeniKayit;
        }

        public void Temizle()
        {
            _kayitlar.Clear();
        }

        public void DosyayaKaydet(string dosyaYolu)
        {
            if (_kayitlar.Count == 0)
                throw new InvalidOperationException("Kaydedilecek herhangi bir tuş kaydı bulunmuyor.");

            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                writer.WriteLine("=== YMH 219 Key Event Logger Kayıt Dökümü ===");
                writer.WriteLine($"Oluşturulma Tarihi: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                writer.WriteLine($"Toplam Tuş Sayısı: {_kayitlar.Count}");
                writer.WriteLine(new string('-', 45));

                foreach (var kayit in _kayitlar)
                {
                    writer.WriteLine(kayit.ToString());
                }
            }
        }
    }
}