namespace VeriGirisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            ConsoleKeyInfo h;
            Console.Clear(); Console.WriteLine("İsim: ");
            ad = Console.ReadLine(); Console.WriteLine($"\nMerhaba {ad}");
            do
            {
                Console.WriteLine("\nÇıkış için X tuşu...");
                h = Console.ReadKey();
            } while (h.KeyChar != 'x');
        }
    }
}