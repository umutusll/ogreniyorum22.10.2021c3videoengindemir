using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            //boyle 200 300 değişkeni tanıtamayız  ürünler sürekli artar azalır yonetmek zorlanır
            // bu yüzden dizileri kullanırız bu tip verileri arraylerde yani dizilerde tutarız
            // kurslar diye array yaptık aşağıda
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "java" };


            for (int i = 0; i<3; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
