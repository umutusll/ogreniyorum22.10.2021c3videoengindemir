using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);  // bu dort işlemin içerisinde topla oldugu için bambaşka bir sayfada topla yazdık 

            dortIslem.Topla(6,9);   // parametreler değişken olanlardır 
        }
    }
}
