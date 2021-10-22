using System;

namespace matematik
{
    class Program
    {
        static void Main(string[] args) //benim birsürü ekranım oldugunu ve toplama yapacagımı düşün 
            // diyorum ki benim toplama yapan metodum var o metod 4 işlem clasının içinde oldugu için brnim o classtan bir tane ornek oluşturmam lazım 
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);// bambaşka sayfada bambaşka sayı yazabilirsin parametreler standart olmadıkları için değişken oldukları için parametreler değişken olanlardır

            dortIslem.Topla(6, 9);
        }
    }
}
