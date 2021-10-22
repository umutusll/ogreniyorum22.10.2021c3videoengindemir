using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager  //burada sepete ürün ekleme işlemini yapalım
    {
        public void Ekle(Urun urun)   //şuan metodumuz bir parametre alıyor bu parametrenin tipi Urun urunun adını     Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi); bööyle yazdırıyoruz
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi) //bunun anlamı ben ürünü ekleyeceğim fakat sen ürünün adını fiyatını açıklamasını ver ki ben veri kaynagına bu üçünü birden ekleyeyim 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi); 
        }
    } 

}
