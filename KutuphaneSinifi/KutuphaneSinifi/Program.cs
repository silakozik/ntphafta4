using System;
using System.Collections.Generic;

public class Kitap
{
    // Kitap özellikleri
    public string Ad { get; private set; }
    public string Yazar { get; private set; }

    // Kitap sınıfı yapıcı metodu: Kitap adı ve yazar adı alınır
    public Kitap(string ad, string yazar)
    {
        Ad = ad;
        Yazar = yazar;
    }
}

public class Kutuphane
{
    // Kitapları tutacak bir liste
    public List<Kitap> Kitaplar { get; private set; }

    // Yapıcı metot: Kitaplar listesi boş olarak başlatılır
    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();
    }

    // Kitap ekleme metodu: Yeni bir kitap ekler
    public void KitapEkle(Kitap yeniKitap)
    {
        Kitaplar.Add(yeniKitap);
        Console.WriteLine($"'{yeniKitap.Ad}' adlı kitap bu {this.GetType().Name} kütüphanesine eklendi.");
    }

    // Tüm kitapları listeleme metodu
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"- {kitap.Ad} (Yazar: {kitap.Yazar})");
        }
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir kütüphane oluşturuyoruz
        Kutuphane kutuphane = new Kutuphane();

        // Kütüphaneye kitap ekliyoruz
        Kitap kitap1 = new Kitap("Yüreğim Seni Çok Sevdi", "Canan Tan");
        Kitap kitap2 = new Kitap("Palto", "Gogol");

        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        // Kütüphanedeki tüm kitapları listeleyelim
        kutuphane.KitaplariListele();

        // Konsolun kapanmasını önlemek için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
