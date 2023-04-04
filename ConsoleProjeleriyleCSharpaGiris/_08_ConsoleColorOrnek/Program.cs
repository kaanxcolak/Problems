namespace _08_ConsoleColorOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# tip bağımlı bir dil demiştik.
            //Burada onu bir kez daha inceleyelim
            //Tipler sadece öğrendiğinniz int decimal bool string char datetime mıdır?
            //HAYIR
            //C#'ta enum yapıları tip olabilir interfaceler ve classlar tip olabilir 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Renk kırmızı oldu!");
            // Console.ResetColor(); // renkleri default ayarına getirir
            Console.ReadKey();
        }
    }
}