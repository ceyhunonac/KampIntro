using System;

namespace KampClassIntro
{
    class Program
    {
        static void Main(string[] args){

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmeni = "Engin Demiroğ";
            kurs1.İzlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmeni = "Kerem Varış";
            kurs2.İzlemeOrani = 63;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmeni = "Berkay Bilgin";
            kurs3.İzlemeOrani = 90;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Eğitmeni = "Murat Kurtboğan";
            kurs4.İzlemeOrani = 100;



            //Console.WriteLine(kurs1.KursAdiKurs kurs1 = new Kurs();


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "  :  " + kurs.Eğitmeni);
            }
        }
    }
    class Kurs
    {
        public String KursAdi { get; set; }

        public String Eğitmeni { get; set; }

        public int İzlemeOrani { get; set; }

        
    }
}