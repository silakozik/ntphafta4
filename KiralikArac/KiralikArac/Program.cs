using System;

public class KiralikArac
{
    // Araç özellikleri
    public string Plaka { get; private set; }
    public decimal GunlukUcret { get; private set; }
    public bool MusaitMi { get; private set; }

    // Yapıcı metot: Plaka ve günlük ücreti alır, MusaitMi varsayılan olarak true
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait
    }

    // Aracı kiralama metodu: MusaitMi durumunu false yapar
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"{Plaka} plakalı araç kiralandı.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten kirada.");
        }
    }

    // Aracı teslim etme metodu: MusaitMi durumunu true yapar
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;
            Console.WriteLine($"{Plaka} plakalı araç teslim edildi.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten müsait.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir kiralık araç oluşturuyoruz
        KiralikArac arac = new KiralikArac("34ABC123", 150);

        // Araç bilgilerini göster
        Console.WriteLine("Araç Plaka: " + arac.Plaka);
        Console.WriteLine("Günlük Ücret: " + arac.GunlukUcret + " TL");
        Console.WriteLine("Araç Müsait Mi: " + (arac.MusaitMi ? "Evet" : "Hayır"));

        // Aracı kirala
        arac.AraciKirala();
        Console.WriteLine("Araç Müsait Mi: " + (arac.MusaitMi ? "Evet" : "Hayır"));

        // Aynı aracı tekrar kiralamayı dene
        arac.AraciKirala();

        // Aracı teslim et
        arac.AraciTeslimEt();
        Console.WriteLine("Araç Müsait Mi: " + (arac.MusaitMi ? "Evet" : "Hayır"));

        // Aracı tekrar teslim etmeyi dene
        arac.AraciTeslimEt();

        // Konsolun kapanmasını önlemek için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
