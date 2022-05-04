using System;
using System.Collections;

namespace odev2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listAsal= new ArrayList();
            ArrayList listAsalD=new ArrayList();
            int i=0;
            int asalSum=0;
            int asalDsum=0;
            while(i<5){
                i++;
                Console.WriteLine("bir sayı Giriniz");
                int num= Convert.ToInt32(Console.ReadLine());
                
                if(isAsal(num)){
                    listAsal.Add(num);
                }else
                {
                    listAsalD.Add(num);
                } 
            }
            listAsal.Sort();
            listAsal.Reverse();
            listAsalD.Sort();
            listAsalD.Reverse();
            Console.WriteLine("asal sayılar: ");
            foreach (int k in listAsal)
            {
                Console.Write(k+"-");
                asalSum +=k;
            }
            Console.WriteLine("***"+ listAsal.Count+" asal sayı vardır. ");
            Console.WriteLine("***"+ (asalSum/ (listAsal.Count))+" asal sayı ort. ");
            
            Console.Write("asal olmayan sayılar: ");
            foreach (int j in listAsalD)
            {
                Console.Write(j+"-");
                asalDsum +=j;
            }
            Console.WriteLine("***"+ listAsalD.Count+" asal olmayan sayı vardır. ");
            Console.WriteLine("***"+ (asalDsum/ (listAsalD.Count))+" asal olmayan sayı ort. ");    
        }


        public static  bool isAsal(int num){
            if(num%2==0){
                return false;
            }else{
                for(int i=3; i*i<=num; i++){
                    if(num%i==0){
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
