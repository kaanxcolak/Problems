namespace _04_ParseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORU: Convert haricinde hangi galaksiler var ??
            //Parse diye bir eleman daha varmış. Haydi tanışalım.
            //Parse'ı google dan hemen araştırdığınızda onun da tıpkı Convert gibi dönüştürme işlemi yaptığını görececksiniz.
            //Convert bir classtır (oopta class detaylı işlenecek)
            //Parse bir metottur.

            Console.WriteLine("Bir sayı giriniz    : ");
            //haydi deneyelim 20 yazın patlamayacak 20, yazın ya da rakam harici yazın patlayacak....
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Teşekkürler");

            Console.ReadKey();
        }
    }
}