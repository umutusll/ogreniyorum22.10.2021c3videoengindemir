using System;

namespace class_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmen = "Berkay Bilgin";
            kurs1.İzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.İzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem Varış";
            kurs3.İzlenmeOrani = 64;




            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2 , kurs3 };
            // önceden string tutuyorduk verinin içinde şimdi kurs tutuyorum

            foreach (var kurs in kurslar)  //foreach ile yapıları tek tek dönüyorduk burada da kursAdi larını tek tek döneceğiz
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }




            //Console.WriteLine("Hello World!");
        }
    }
}
class Kurs   //biz burada kursu tanımladık mesela string bir obje kurs da bir obje fakat uygulama kursun bir obje o
    //oldugunu anlayamıyor biz class kelimesinin yanına kurs yazarak kursu bir obje olarak tanımlamış oluyoruz
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int İzlenmeOrani { get; set; }
    // bir tane kurs objesi oluşturuyoruz sadece stringler sayılar değil hepsini beraber tutuyoruz 
    // benim artık kurs1 im var tipi kurs önceden string kurs1 ="umut"; bu şekilde sadece 1 veri tutabiliyordum 
    // fakat şuan kurs tipi 1 den fazla veri tutuyor içinde
    // public string KursAdi { get; set; }
    // public string Egitmen { get; set; }
    // public int İzlenmeOrani { get; set; } bu şekilde
}