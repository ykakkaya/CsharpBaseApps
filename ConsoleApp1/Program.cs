using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yemekSiparis
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim, toplam, adet = 0;
            double hesap = 0;
            Console.WriteLine("****************************************************************");
            Console.WriteLine(" ");
            Console.WriteLine("**          Yemekler          **          İçecekler          **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**      1-ET DÖNER    40TL    **        7- AYRAN 5TL           **");
            Console.WriteLine("**      2-TAVUK DÖNER 30TL    **        8- KOLA  10TL          **");
            Console.WriteLine("**      3-ÇORBA       20TL    **        9- SU    2TL           **");
            Console.WriteLine("**      4-SALATALAR   10TL    **        10-ÇAY   2TL           **");
            Console.WriteLine("**      5-KURU-PİLAV  40TL    **        11-FANTA 10TL          **");
            Console.WriteLine("**      6-PİDELER     25TL    **        12-SODA  3TL           **");
            Console.WriteLine("****************************************************************");

            bool start = true;

            while(start)
            {
                Console.WriteLine();
                Console.Write("alacağını ürünün numarasını giriniz");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet= Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 40;
                    hesap = hesap + toplam;
                }else if (secim == 2)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 30;
                    hesap = hesap + toplam;
                }else if (secim == 3)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 20;
                    hesap = hesap + toplam;

                }else if (secim == 4)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }
                else if (secim == 5)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 40;
                    hesap = hesap + toplam;
                }
                else if (secim == 6)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 25;
                    hesap = hesap + toplam;

                }
                else if (secim == 7)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }
                else if (secim == 8)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }
                else if (secim == 9)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap = hesap + toplam;

                }
                else if (secim == 10)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap = hesap + toplam;
                }
                else if (secim == 11)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 10;
                    hesap = hesap + toplam;
                }
                else if (secim == 12)
                {
                    Console.WriteLine("kaç porsiyon istiyorsunuz");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap = hesap + toplam;

                }
                else
                {
                    Console.WriteLine("yanlış seçim yaptınız");
                }
                Console.WriteLine();
                Console.WriteLine("başka isteğiniz var mı? evet-hayır");
                String cevap = Console.ReadLine();
                if (cevap == "hayır")
                {
                    start = false;
                }

            }
            Console.WriteLine("toplam ödenecek: " + hesap);

            Console.ReadLine();
        }
    }
}
