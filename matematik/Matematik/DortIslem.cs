using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem //neden bu classı oluşturduk çünkü toplama da bi metod çıkarma da çarpma da bölme de 
    {
        public void Topla(int sayi1, int sayi2)  //() parametre kısmı parantez kısmı 2 sayıyı toplayacagınızı varsayarsak parametre kısmı sizin ihtiyacınız olanlar toplama yapmak için 2 sayıya ihtiyaç var sepete eklemek için ürüne ihtiyaç var 
            //çağırabilmen için ona 2 sayı vermen lazım
        {
            int toplam = sayi1 + sayi2;  // aslında topla(2,3)diyerek yapabiliriz fakat biz istedigimiz zaman istedigimiz sayıyı toplayabilsin diye metot yapıyoruz
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
