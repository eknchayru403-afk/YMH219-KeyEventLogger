# YMH 219 - Key Event Logger Uygulaması

* **Öğrenci Adı Soyadı:** Hayrunnisa Ekinci
* **Öğrenci Numarası:** 240541043
* **Ders:** YMH 219 - Görsel Programlama / Nesne Yönelimli Programlama

## Proje Hakkında
Bu proje, C# Windows Forms (.NET) kullanılarak geliştirilmiş, uygulama penceresi odaktayken (in-app) gerçekleşen klavye tuş basımlarını (`KeyDown`) zaman damgasıyla birlikte yakalayan, listeleyen ve dışa aktarabilen bir olay günlüğü (Key Event Logger) uygulamasıdır.

## Temel Özellikler
* **Kontrollü Kayıt Yönetimi:** `Başlat` ve `Durdur` butonları ile klavye dinleme durumu güvenli bir şekilde yönetilir.
* **Zaman Damgalı Kayıt:** Basılan her tuş milisaniye hassasiyetinde tarih/saat bilgisiyle birlikte listelenir ve toplam tuş sayacı anlık güncellenir.
* **Nesne Tabanlı Mimari (OOP):** Veri modeli (`KeyLogEntry`) ve iş mantığı/dosya yönetimi (`KeyLoggerManager`), arayüz katmanından (`Form1`) tamamen ayrılmıştır.
* **Dışa Aktarma & Hata Yönetimi:** Kaydedilen tuş geçmişi `SaveFileDialog` aracılığıyla `.txt` formatında dışa aktarılabilir; boş liste ve dosya yazma hataları kontrollü şekilde yönetilir.

## Kurulum ve Çalıştırma
1. Depoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/eknchayru403-afk/YMH219-KeyEventLogger.git](https://github.com/eknchayru403-afk/YMH219-KeyEventLogger.git)
