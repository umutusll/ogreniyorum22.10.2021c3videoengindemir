using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class Urun  //classların 2 temel ozelliği var 1. özellik tutmaları o yüzden ürün dedik ürüne birde ıd ekledik id bir datayı diğerlerinden ayırt etmek için kullandıgımız essiz değeri anlatır tc kimlik no gibi 
    {
        //property-özellik 
        public int Id { get; set; } 
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

    }
}
