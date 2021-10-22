using System;

namespace while_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int i = 0;

            while (i < 100)
            {
                toplam += i;
                i++;
            }

            Console.WriteLine("1-100 arası sayıların toplamı ":(toplam));

        }
    }
}
