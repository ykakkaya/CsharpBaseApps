using System;
using System.Collections.Generic;

namespace odev2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir cümle giriniz");
            string str= Console.ReadLine();
            char[]ch=new char[str.Length];
            List<char>sesli= new List<char>();
            ch=str.ToCharArray();
            for(int i=0 ;i<ch.Length;i++)
            {
                if(ch[i].Equals('a')||ch[i].Equals('e')||ch[i].Equals('ı')||ch[i].Equals('i')||ch[i].Equals('o')||
                ch[i].Equals('ö')||ch[i].Equals('u')||ch[i].Equals('ü'))
                {
                    
                    sesli.Add(ch[i]);
                }

            }
            Console.WriteLine("cümledeki sesli harfler");
            foreach (var item in sesli)
            {
                Console.Write(item+" ");
            }

        }
    }
}
