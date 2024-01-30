using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimOrnek
{
    public class Shape 
    {
        public string isim { get; set; }

        public Shape(string isim)
        {
            this.isim = isim;
        }


        public string getIsim()
        {
            return this.isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor...");
        }

        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + " nin bilgileri !");
        }
    }
}
