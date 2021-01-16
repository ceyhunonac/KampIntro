using System;

namespace KampLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            String kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            String kurs2 = "Programlamaya Başlangıç İçin Temel Kursu";
            String kurs3 = "Java Kursu";

            String[] kurslar = new String[] { "Yazılım Geliştirici Yetiştirme Kursu",
                "Programlamaya Başlangıç İçin Temel Kursu",
                "Java Kursu","Python Kursu","C#"};
            


            for (int i= 0;i<kurslar.Length;i++)
            {

                Console.WriteLine(kurslar[i]);
            }
                Console.WriteLine("FOR DÖNGÜSÜ BİTTİ");

            foreach (String kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
