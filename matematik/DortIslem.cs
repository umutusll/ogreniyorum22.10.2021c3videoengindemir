using System;
using System.Collections.Generic;
using System.Text;

namespace matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) // 2 sayıyı toplayacagımızı varsayarsak Topla() kısmı bizim metodumuzun ihtiyacı olanlar aslında toplama yapabilmek için 2 sayıya sepete ekleyebilmek için bir ürüne ihtiyacı var
        {
            //Topla(2,3)
            int toplam = sayi1 + sayi2; // niye sayı 1 sayi 2 diyoruz diye düşünme çünkü bu şablon birazdan çagırınca sen buna topla diyince 2 tane parametre geçeceksin 
            Console.WriteLine("Sonuç : " + toplam);
        }







    }
}
