using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil uygulamasına hoşgeldiniz !");

            while (true)
            {
                Console.WriteLine("İşlem Seçiniz");
                Console.WriteLine("1- Dikdörtgen işlemleri");
                Console.WriteLine("2- Üçgen İşlemleri ");
                Console.WriteLine("3- Kare İşlemleri");
                Console.WriteLine("4- q'ya basarak çıkınız");

                string secim = Console.ReadLine();

                if (secim == "q")
                {
                    break;
                }

                else if (secim == "1")
                {

                    while (true)
                    {

                        Console.WriteLine("1-Dikdörgen alan hesapla ");
                        Console.WriteLine("2-Dikdörtgen bilgileri göster");
                        Console.WriteLine("3-Dikdörtgen çıkış yap");

                        string secimdikdortgen = Console.ReadLine();

                        if (secimdikdortgen == "1")
                        {
                            Console.WriteLine("Kısa kenarı giriniz : ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun kenarı giriniz : ");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Rectangle dikdortgen = new Rectangle("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilHesapla();
                        }

                        else if (secimdikdortgen == "2")
                        {
                            Console.WriteLine("Kısa kenarı giriniz : ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Uzun kenarı giriniz : ");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Rectangle dikdortgen = new Rectangle("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilBilgileriGoster();
                        }

                        else if (secimdikdortgen == "q")
                        {
                            Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor...");
                            break;
                        }
                    }
                }

                else if (secim == "2")
                {


                    while (true)
                    {
                        Console.WriteLine("1-Üçgenin alan hesapla ");
                        Console.WriteLine("2-Üçgenin bilgileri göster");
                        Console.WriteLine("3-Üçgenden çıkış yap");

                        string secimucgen = Console.ReadLine();
                        if (secimucgen == "1")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz : ");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Triangle ucgen = new Triangle("Üçgen", tabanalani, yukseklik);
                            ucgen.sekilHesapla();
                        }

                        else if (secimucgen == "2")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz : ");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Triangle ucgen = new Triangle("Üçgen", tabanalani, yukseklik);

                            ucgen.sekilBilgileriGoster();


                        }

                        else if (secimucgen == "q")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor");
                            break;
                        }
                    }
                }

                else if (secim == "3")
                {


                    while (true)
                    {
                        Console.WriteLine("1-Karenin alan hesapla ");
                        Console.WriteLine("2-Karenin bilgileri göster");
                        Console.WriteLine("3-Karenin çıkış yap");
                        string secimkare = Console.ReadLine();

                        if (secimkare == "1")
                        {
                            Console.WriteLine("Karenin kenarını giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Square kare = new Square("Kare", kenar);

                            kare.sekilHesapla();

                        }

                        else if (secimkare == "2")
                        {
                            Console.WriteLine("Karenin kenarını giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Square kare = new Square("Kare", kenar);

                            kare.sekilBilgileriGoster();
                        }

                        else if (secimkare == "q")
                        {
                            Console.WriteLine("Kare işlemlerinden çıkılıyor...");
                            break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz.");
                }


            }



        }
    }
}
