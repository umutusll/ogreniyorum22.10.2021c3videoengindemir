using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        //naming convertion 
        //bir yerde normal bi parantez görüyorsanız orada bir metod geçiyordur
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }
    }   public void Ekle2()
    {
        for (int i = 0; i < 100; i=i+2)
        {
            Console.WriteLine(i);
        }
}
}
