namespace _09_ConsoleColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console arka plan rengi değiştirir.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear(); //Console'un arka plan rengini deiştirince console'u clear yapmayı unutmayalım.
            //Çünkü Console yaratılırken bufferdaki default bilgileriyle yaratılıyor.
            //Console win form ve web kadar dinamik yapıda olmadığı için buffer'ı temizleyecek clear kodunu yazarsak 
            // bu işlemi yapacaktır --> Clears the console buffer and corresponding console window of display information.
            Console.WriteLine("\n \n \t Merhaba "); // \t tab yapar \n alt satıra geçer



            Console.ReadKey();
        }
    }
}