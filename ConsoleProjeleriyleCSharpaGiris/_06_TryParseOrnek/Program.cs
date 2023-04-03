namespace _06_TryParseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazılımcılar olarak her zaman temkinli olmalıyız
            //İyi yazılımcı hızlı kod yazandan öte detayları düşünüp en az patlama ile temiz kod yazan yazılımcıdır
            //Try Parse için Parse'ın kuzeni diyebiliriz.
            
            Console.WriteLine("****************\n"); // /n ile alt satıra geçme işlemi yapılır.
            int sayi = 0;
            Console.WriteLine("Bir sayi giriniz: ");

            bool kontrol = Int32.TryParse(Console.ReadLine(), out sayi);
            Console.WriteLine($"Girdiğiniz değer integer'a uygun mudur? Cevap: {kontrol}");
        }
    }
}