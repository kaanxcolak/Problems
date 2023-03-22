namespace _01_ConvertOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Amaç: int tipli değişkeni kullanmak
            //Convert ile tanışmak
            //Özetle Convert dönüştürmek demektir. Console.ReadLine string bir tiptedir. Oysa bize int tip gerekiyor
            //Bu nedenle dönüşüm yaptık. Console uygulamasında convert sınıfını çokça kullanacağım!!!
            //Kullanıcıdan 2 sayı alıp toplayalım
            int sayi1 = 0, sayi2 = 0;

            Console.WriteLine("Bir sayi giriniz{sayi1 + sayi2}: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı daha giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sonuc = {sayi1 + sayi2}");
            Console.ReadKey();
        }
        
    }
}