using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi= "Elma";
            double fiyati= 15;
            string aciklama= "Amasya elması";
            
            string[] meyveler = new string[] { };  //sadece stringler tutabilriz böyle 

            Urun urun1 = new Urun();
            urun1.Adi ="Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama ="Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // baştaki Urun  kısmına veri  tipini yazıyoruz
            foreach (var urun in urunler) //in urunler urunler adlı dizimin elemanlarını tek tek gez // urun takma ad alias denir
            {
                Console.WriteLine("urun.Adi");
                Console.WriteLine("urun.Fiyati");
                Console.WriteLine("urun.Aciklama");
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------Metotlar---------");
            Console.WriteLine();
            //instance-örnek 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
           
            
        }   
    }
}


//dont repeat yourself - Clear Code - Best Practice