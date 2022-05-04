using System;
using System.Collections.Generic;

namespace phoneList
{
    
    
    class Program
    {
        static List<Rehber> rehberList=new List<Rehber>();
        static void Main(string[] args)
        {
            Rehber rehber=new Rehber("ali","ateş","123456");
            rehberList.Add(rehber);
            Rehber rehber1=new Rehber("ahmet","demir","147258");
            rehberList.Add(rehber1);
            Rehber rehber2=new Rehber("ibrahim","toma","258369");
            rehberList.Add(rehber2);
            Rehber rehber3=new Rehber("akın","tek","369258");
            rehberList.Add(rehber3);
            int i=0;
            while (i==0)
            {
                Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ");
                Console.WriteLine("1-rehbere numara kaydet \n 2-rehberden numara sil \n 3-numara güncelle \n 4-rehber listeleme \n 5- rehberde arama \n 6-çıkış");
                int sec=Convert.ToInt32(Console.ReadLine());
                switch (sec)
                {
                    case 1: kisiEkle();
                    break;
                    case 2: kisiSil();
                    break;
                    case 3: kisiUpdate();
                    break;
                    case 4: rehberListele();
                    break;
                    case 5: kisiSearch();
                    break;
                    case 6: sec=0;
                            i=-1;
                    break; 
                    default: Console.WriteLine("tekrar seçim yapınız");
                    break;
                }

            }
            
             
        }
        public static void kisiEkle(){
            Console.WriteLine("eklenecek kişinin adı");
            String name= Console.ReadLine();
            Console.WriteLine("eklenecek kisinin soyadı");
            String surname= Console.ReadLine();
            Console.WriteLine("eklenecek kişinin telefon numarası");
            String telNumber= Console.ReadLine();
            Rehber kisi1 = new Rehber(name,surname,telNumber);
            rehberList.Add(kisi1);
        }
        public static void kisiSil(){
            int sorgu=2;
            while(sorgu==2)
            {
                sorgu++;
                Console.WriteLine("Silinecek kişinin adı");
                String name= Console.ReadLine();
                Console.WriteLine("Silinecek kisinin soyadı");
                String surname= Console.ReadLine();

                for(int i=0; i<rehberList.Count;i++)
                {
                   if(rehberList[i].getName().Equals(name) && rehberList[i].getSurname().Equals(surname) )
                   {
                       Console.WriteLine("isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                       String result= Console.ReadLine();
                       if (result.Equals("y"))
                       {
                           rehberList.RemoveAt(i);
                           Console.WriteLine("silme işlemi gerçekleşti");
                           Console.WriteLine("çıkmak için 1 e basınız \n yeniden arama yapmak için 2 ye basınız. ");
                           sorgu= Convert.ToInt32(Console.ReadLine());
                           break;
                       }else
                       {
                           Console.WriteLine("çıkmak için 1 e basınız \n yeniden arama yapmak için 2 ye basınız. ");
                           sorgu=Convert.ToInt32(Console.ReadLine());
                           break;
                       }
                    }
                    
                }
            }
            
        }

        public static void kisiUpdate()
        {
            int choose=0;
            while(choose==0){
                choose++;
                Console.WriteLine("Güncellenecek kişinin adı");
                String name= Console.ReadLine();
                Console.WriteLine("Güncelenecek kisinin soyadı");
                String surname= Console.ReadLine();
                
                for(int i=0; i<rehberList.Count;i++)
                {
                   if(rehberList[i].getName().Equals(name) && rehberList[i].getSurname().Equals(surname) )
                   {
                       Console.WriteLine("yeni telefon numarasını giriniz");
                       String num=Console.ReadLine();
                       rehberList[i].setTelNumber(num);
                       Console.WriteLine("numara güncellendi.Yeni numara: "+num);
                       Console.WriteLine("güncellemeyi sonlandırmak için 1 e basınız. \n yeniden denemek için 2 ye basınız.");
                       int secim=Convert.ToInt32(Console.ReadLine());
                       if (secim==1)
                       {
                           choose=2;
                           break;
                       }else
                       {
                           choose=0;
                           break;
                       }
                   
                    }
                   
                       
                   
                }
            }

        }

        public static void rehberListele()
        {
            Console.WriteLine("Telefon Rehberi \n **********************");
            foreach (var item in rehberList)
            {
                Console.WriteLine("İsim: "+item.getName());
                Console.WriteLine("Soyisim: "+item.getSurname());
                Console.WriteLine("Numara: "+item.getTelNumber());
                Console.WriteLine("**********************");
            } 
        }

        public static void kisiSearch(){
            Console.WriteLine("arama yapmak istediğini tipi seçiniz: \n isim ve soyisim ile arama yapmak için (1) \n numarayla aramak için (2)");
            int secim= Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
                Console.WriteLine("kişinin adı");
                String name= Console.ReadLine();
                Console.WriteLine("kisinin soyadı");
                String surname= Console.ReadLine();
                for(int i=0; i<rehberList.Count;i++)
                {
                   if(rehberList[i].getName().Equals(name) && rehberList[i].getSurname().Equals(surname) )
                   {
                       Console.WriteLine("arama sonucunuz : ");
                       Console.WriteLine("isim : "+rehberList[i].getName());
                       Console.WriteLine("soyisim : "+ rehberList[i].getSurname());
                       Console.WriteLine("numara : "+ rehberList[i].getTelNumber());
                       break;
                   }
                }      
            }else if (secim==2)
            {
                Console.WriteLine("telefon numarasını giriniz");
                string tno=Console.ReadLine();
                for(int i=0; i<rehberList.Count;i++){
                    if(rehberList[i].getTelNumber().Equals(tno)){
                        Console.WriteLine("adı: "+ rehberList[i].getName());
                        Console.WriteLine("Soyadı: "+ rehberList[i].getSurname());
                        break;
                    }
                }
            }

            
        }

        


       
    }
}
