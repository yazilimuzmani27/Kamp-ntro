using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kampı";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizi -BU DİMAMİK BİR KOD BLOĞUDUR-

            string[] kurslar = new string[] { "Yazılım geliştirici kampı", "Proglamlamaya başlangıç için temel kurs", "java" ,"Python"};
       
            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("sayfa sonu");
        }
    }
}
