namespace _11_ConsoleColorOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ile 15 arasında bir değer giriniz    :");

            byte renkSecimi = Convert.ToByte(Console.ReadLine());
            //Aşağıdaki kodlar Yukarıdakiyle aynı işlemleri yapar. Önceki örneklerde inceledik
            //byte renkSecimi = Byte.Parse(Console.ReadLine());
            //Değişkeni önceden tanımlamazsan içerde tip vererek tanımlayabilirsiniz
            // byte.TryParse(Console.ReadLine(), out byte renkSecimi);
            // int renkSecimi;  // önceden tanımlandıysa direk ismini yazarak kullanabilirsiniz.
            // byte.TryParse(Console.ReadLine(), out renkSecimi);

            Console.WriteLine("Konsol rengi değiştiriliyor....");
            Console.ForegroundColor = (ConsoleColor)renkSecimi;

            Console.WriteLine("Konsole rengi " + Console.ForegroundColor.ToString() + " rengine ayarlandı...");
            Console.WriteLine("Konsole rengi {0} rengine ayarlandı...", Console.ForegroundColor.ToString());
            Console.WriteLine($"Konsole rengi {Console.ForegroundColor.ToString()} rengine ayarlandı...");

            Console.ResetColor();
            Console.WriteLine("Konsol rengi varsayılan renge ayarlandı....");


            Console.ReadKey();
        }
    }
}