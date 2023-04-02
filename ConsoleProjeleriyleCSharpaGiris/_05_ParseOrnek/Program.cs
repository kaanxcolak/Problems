namespace _05_ParseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek: Boy kütle indeksi hesaplama
            double boy = 0, kilo = 0, bki = 0;

            Console.WriteLine("Boy giriniz: ");
            boy = double.Parse(Console.ReadLine());// parse bir metot ise ben onu ihtiyacım oldukça çağıracağım
            //Boolean.Parse--> bu da bool 'a dönüştürüyor.
            Console.WriteLine("Kilo Giriniz: ");
            kilo = double.Parse(Console.ReadLine());

            bki = kilo / (boy * boy);
            Console.WriteLine($"Boy = {boy}, Kilo ={kilo}, Kitle İndeksi: {bki} " + bki, boy,kilo,bki);



        }
    }
}