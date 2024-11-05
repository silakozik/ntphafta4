using System;

public class BankaHesabi
{
    // Hesap numarası özelliği, dışarıdan sadece okunabilir
    public string HesapNumarasi { get; private set; }

    // Bakiye özelliği, sadece sınıf içinden değiştirilebilir
    private decimal bakiye;

    public decimal Bakiye
    {
        get { return bakiye; }
        private set { bakiye = value; }
    }

    // Yapıcı metot: Hesap numarası ve ilk bakiye değerini alır
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }

    // ParaYatir metodu: Pozitif bir miktar girildiğinde bakiyeye ekler
    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Geçersiz miktar.");
        }
    }

    // ParaCek metodu: Yeterli bakiye varsa belirtilen miktarı bakiyeden çıkarır
    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz miktar.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir banka hesabı oluşturuyoruz
        BankaHesabi hesap = new BankaHesabi("12345", 1000);


            // Para yatırma işlemi
            Console.Write("Yatırmak istediğiniz miktarı girin: ");
            decimal yatirMiktar = decimal.Parse(Console.ReadLine());
            hesap.ParaYatir(yatirMiktar);

            // Para çekme işlemi
            Console.Write("Çekmek istediğiniz miktarı girin: ");
            decimal cekMiktar = decimal.Parse(Console.ReadLine());
            hesap.ParaCek(cekMiktar);

        // Konsolun kapanmasını önlemek için
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
