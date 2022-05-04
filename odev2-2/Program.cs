using System;

namespace odev2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            int[]numbers=new int [20];
            while (i<20)
            {
                Console.WriteLine((i+1) +" inci sayı yı giriniz");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Array.Sort(numbers);
            Console.WriteLine("en küçük üç eleman: "+numbers[0]+" "+numbers[1]+" "+numbers[2]);
            Console.WriteLine("en küçük üç eleman toplamı: "+ (double)(numbers[0]+numbers[1]+numbers[2]));
            Console.WriteLine("en küçük üç eleman ortalaması: "+(double)((numbers[0]+numbers[1]+numbers[2])/3));
            Array.Reverse(numbers);
            Console.WriteLine("en büyük üç eleman: "+numbers[0]+" "+numbers[1]+" "+numbers[2]);
            Console.WriteLine("en büyük üç eleman toplamı: "+ (double)(numbers[0]+numbers[1]+numbers[2]));
            Console.WriteLine("en büyük üç eleman ortalaması: "+(double)((numbers[0]+numbers[1]+numbers[2])/3));
        }
    }
}
