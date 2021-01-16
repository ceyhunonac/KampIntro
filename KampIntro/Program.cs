using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String kategorietiketi = "Katagori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            Boolean sistemeGirişYapılmışMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun) {
                Console.WriteLine("Azalış Butonu");

            } else if (dolarDun > dolarBugun) {
                Console.WriteLine("Artış Butonu");
            } else { 
           Console.WriteLine("Değişmedi Butonu");
                
            }
           

            if (sistemeGirişYapılmışMı == true){
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategorietiketi);
            Console.ReadLine();
           



        }
    }
}
