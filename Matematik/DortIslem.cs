using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int Sayi1,int Sayi2)
        {
            int toplam = Sayi1 + Sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Cıkar(int Sayi1, int Sayi2)
        {
            int toplam = Sayi1 - Sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Carp(int Sayi1, int Sayi2)
        {
            int toplam = Sayi1 * Sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Bol(int Sayi1, int Sayi2)
        {
            int toplam = Sayi1 / Sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
