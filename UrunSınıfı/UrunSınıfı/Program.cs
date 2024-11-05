using System;

public class Urun
{
    // Ürün adı ve fiyat özellikleri
    public string Ad { get; private set; }
    public decimal Fiyat { get; private set; }

    // İndirim özelliği, 0-50 arası değerlerle sınırlı
    private decimal indirim;
    public decimal Indirim
    {
        get { return indirim; }
        set
        {
            // İndirim oranı 0-50 arasında ise değeri ayarla, değilse uyarı ver
            if (value >= 0 && value <= 50)
            {
                indirim = value;
            }
            else
            {
                Console.WriteLine("İndirim oranı 0 ile 50 arasında olmalıdır.");
            }
        }
    }

    // Yapıcı metot: Ad ve fiyat bilgilerini alır, indirim varsayılan olarak 0
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
        Indirim = 0; // Varsayılan indirim değeri %0
    }

    // IndirimliFiyat metodu: İndirim uygulanmış fiyatı döndürür
    public decimal IndirimliFiyat()
    {
        return Fiyat - (Fiyat * Indirim / 100);
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir ürün oluşturuyoruz
        Urun urun = new Urun("Laptop", 5000);

        // Ürünün adını, fiyatını ve indirim oranını göster
        Console.WriteLine("Ürün Adı: " + urun.Ad);
        Console.WriteLine("Ürün Fiyatı: " + urun.Fiyat + " TL");

        // İndirim oranını ayarla
        urun.Indirim = 20;
        Console.WriteLine("Uygulanan İndirim: " + urun.Indirim + "%");

        // İndirimli fiyatı hesapla ve göster
        Console.WriteLine("İndirimli Fiyat: " + urun.IndirimliFiyat() + " TL");

        // Hatalı indirim oranı girmeyi denersek
        urun.Indirim = 60; // Bu durumda sınıf uyarı verecek ve değer değişmeyecek

        // Konsolun kapanmasını önlemek için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
