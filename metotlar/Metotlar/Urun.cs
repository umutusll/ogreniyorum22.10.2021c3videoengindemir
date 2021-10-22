using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun  // biz bir urun oluşturduk bu ürünü sepete ekleyeceğiz
    {
        //bir ürünün ürün olabilmesi için çeşitli ozelliklere sahip olması lazım 
        //classlarla ilgili bir kullanım o urunun muşterinin bilgilerini tutmaktı bunları da 
        //property dediğimiz(türkçesi özellik ) alttakilerin her biri property 
        public int Id { get; set; }  //ürünün ıd özelligi
        public string Adi { get; set; } // ürünün adı özelligi 
        public double Fiyati { get; set; }//ürünün fiyatı özelligi 
        public string Aciklama { get; set; } // ürünün bir açıklaması olması özelliği

        public int StokAdedi { get; set; }
    }
    

}
