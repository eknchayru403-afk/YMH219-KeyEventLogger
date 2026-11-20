using System;

namespace YMH219_KeyEventLogger
{
    // Her bir tuş basımını nesne olarak tutan model sınıfı
    public class KeyLogEntry
    {
        public string TusAdi { get; set; }
        public DateTime Zaman { get; set; }

        public KeyLogEntry(string tusAdi)
        {
            TusAdi = tusAdi;
            Zaman = DateTime.Now;
        }

        // ListBox ve .txt dosyasında görünecek standart format
        public override string ToString()
        {
            return $"[{Zaman:yyyy-MM-dd HH:mm:ss.fff}] Basılan Tuş: {TusAdi}";
        }
    }
}