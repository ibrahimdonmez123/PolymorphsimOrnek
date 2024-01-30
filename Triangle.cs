using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimOrnek
{
    public class Triangle : Shape
    {
        public int tabanalani { get; set; }
        public int yukseklik { get; set; }

        public Triangle(string isim, int tabanalani, int yukseklik) : base(isim)
        {
            this.tabanalani = tabanalani;
            this.yukseklik = yukseklik;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " nin alanı : " + (tabanalani * yukseklik) / 2);
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi :" + getIsim());
            Console.WriteLine(getIsim() + " nin taban alanı  : " + this.tabanalani);
            Console.WriteLine(getIsim() + " nin yüksekliği : " + this.yukseklik);
        }
    }
}
