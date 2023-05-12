using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IFClauseNedir
{
    class Program
    {
        static void Main(string[] args)
        {
        // Karar yapısı ne demektir?        
        // if bloğu içinde true ya da false değer dönürerek true geldiyse kod bloğu içine girer ya da false gelirse girmez.

        

        Baslangic:
            int sayi1 = 0;
            Console.Write("Sayı Gir     :");
            bool kontrol1 = Int32.TryParse(Console.ReadLine(), out sayi1);



            //Eğer kullanıcı gerçekten sayısal değer girdiyse tryparse bana evet bu sayısal diyecek yani true verecektir.
            //if (kontrol1 == true) ya da if(kontrol1) kontrol1 zaten boolean olduğu için tekrar eşitlemeden kullanabiliirsiniz
            if (kontrol1)
            {
                Console.WriteLine("Doğru giriş yaptınız!");
            }
            //if (kontrol1 != true)
            else
            {
                Console.WriteLine("YANLIŞ giriş yaptınız! Sizi başa yönlendiriyoruz...");
                Console.WriteLine("\n");
                goto Baslangic;
            }
            Console.ReadKey();


        }
    }
}
