using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu üç özellik elma ile ilgili özelliklerdir.
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "diyarbakır karpuzu";

            //Product yerine string de olabilirdi o zaman string[] yazmamız gerekirdi. Yanında yazan products dizinin
            //ismidir xyz de olabilir.

            Product[] products = new Product[] {product1 , product2 };
            
            //for each deki Product artık bir veri tipidir. genelde bunun yerine var kullanılır.

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("------------------Metotlar----------------");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);

            sepetmanager.Ekle2("Armut", "yeşil armut", 15);
            sepetmanager.Ekle2("Elma", "yeşil elma",12);
            sepetmanager.Ekle2("karpuz","diyarbakır karpuzu",25);
        }
    }
}
