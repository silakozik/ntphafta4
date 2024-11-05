using System;

public class Kisi
{
    // Kişinin adı, soyadı ve telefon numarası özellikleri
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string TelefonNumarasi { get; private set; }

    // Yapıcı metot: Ad, soyad ve telefon numarasını alarak başlatır
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    // KisiBilgisi metodu: Kişinin tam adı ve telefon numarasını döndürür
   public string KisiBilgisi()
    {
        return $"Ad Soyad: {Ad} {Soyad} \nTelefon Numarası: {TelefonNumarasi}";
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir kişi oluşturuyoruz
        Kisi kisi = new Kisi("Sıla", "Kozik", "05525567870");

        // Kişinin bilgilerini göster
        Console.WriteLine(kisi.KisiBilgisi());

        // Konsolun kapanmasını önlemek için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();

    }
}