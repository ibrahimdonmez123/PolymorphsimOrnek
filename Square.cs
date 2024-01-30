using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimOrnek
{
    public class Square : Shape
    {
        public int kenar { get; set; }

        public Square(string isim, int kenar) : base(isim)
        {
            this.kenar = kenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " nin alanı :" + (kenar * kenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi :" + getIsim());
            Console.WriteLine(getIsim() + " nin kenarı  : " + this.kenar);

        }
    }
}
