using System;

namespace KampMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 2;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 1;

            Urun[] urunler = new Urun [] {urun1,urun2};

            foreach (Urun urun in urunler)   
            {
                Console.WriteLine(urun.Adi );
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--------Metotlar---------");

            SepetManager manager = new SepetManager();
            manager.Ekle(urun1);
            manager.Ekle(urun2);

            manager.Ekle2("elma","İyi elma",12,3);
            manager.Ekle2("karpuz", "İyi karpuz ", 15,4);
            manager.Ekle2("armut", "İyi armut", 10,6);





        }
    }
}
