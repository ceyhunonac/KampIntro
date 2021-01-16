using System;
using System.Collections.Generic;
using System.Text;

namespace KampMethods
{
    class SepetManager {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi: " + urun.Adi);
        }
        public void Ekle2(String UrunAdi,string Acıklama, double Fiyat,int StokAdedi)
        {

            Console.WriteLine("Tebrikler.Sepete Eklendi: " + UrunAdi);
        }
        
    }
}
