using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); //Urun tipinde urun1 tanımladık //class oldugu için newlemem gerekiyor //classtan bir değişken tanımladıgımızda new yazdırıyoruz başına
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 }; //urun arreyi oluşturduk 
                                                        //ben bir diziyi dönebilirim foreach ile

            foreach (Urun urun in urunler) // urunler elemanımın herbirini tek tek gez
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("--------------Metotlar------------");

            //aşagıda yaptıgımız işleme instance denir bu bi class ise önce bunun bir örneğini oluşturduk 

            SepetManager sepetManager = new SepetManager();
            //sepet manager dedigimiz için o dosyanın içindekiler geldi Ekle mesela
            
            sepetManager.Ekle(urun1);   //bir sürü sayfada sepete ekleme simülasyonu yapıyoruz
            sepetManager.Ekle(urun2);   //çalıştırdıgımız zaman 5 farklı sayfada aynı sonucu verdi 
                                        //demekki metot bana tekrar tekrar aynı şeyi kullanabilme imkanı verdi 
                                        // eğer yarın bir değişiklik gelirse sepete eklemenin kodunun değiştiğini düşün
                                        //önceden 5 sayfada Sepete eklendi! yazarken şuan Tebrikler. Sepete eklendi ! yazıyor 

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10); //ekle2 bana diyor ki ben ürünü ekleyecegim ama bana ürünün adını açıklamasını ve fiyatını söyle
            sepetManager.Ekle2("Elma", "Yeşil armut", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
            //bu yazdıgımız kod sepet managerde 14. satırda yazdıgımız koda gidiyor ve içerisinde ne yazıyorsa onu yazdırıyor

            //niye illa class yapıyoruz çünkü üstteki 3 örneği 3 farklı sayfada yazdıgımızı düşün yonetim diyor ki stok adetlerini de girin o zaman her yeri gidip değiştirmemiz gerekecek
            Console.ReadKey();
        }
    }
}


//Dont repeat yourself-kendini tekrar etme 
