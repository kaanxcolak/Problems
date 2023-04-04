namespace _10_ConsoleColorEnumdanGelir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor bir enum'dır. 
            //Enum nedir?
            //Bu yapı yazılım dilinde enum, enumaration ya da enum sabitleri olarak adlandırılır.
            //Değişkenlerin alabileceği değerlerin sabit (belli) olduğu durumlarda programı daha okunabilir hale
            //getirmek için kullanılır. Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir.

            //Enum'un sayısal değereine ulaşmanın kısa yolu
            //Enumaration kendi içinde Name ve Value değerini tutuyor. 
            //Tuttuğu değeri ekranda gösterelim.
            int kirmiziRenk = Convert.ToInt32(ConsoleColor.Red);
            //Enum'un sayısal değereine ulaşmanın uzun yolu
            //Parse etmek convert etmek gibidir. 
            //ConsoleColor'ın yellow değerini toString metodunu kullanarak value değerine ulaştık.
            //Ulaştığımız değer object tipte geri dönüş yaptığı için onu int'e çevirdik
            //çünkü int tipinde bir değişkende tutuyoruz.
            int sariRenk = Convert.ToInt32(Enum.Parse(typeof(ConsoleColor), ConsoleColor.Yellow.ToString()));


            // EKSTRA Bİlgi //(int)--> casting işlemidir 
            //Convert etmek yerine kast etmek istediğimizde kısa yöntem olarak parantez içine tip yazabiliriz.
            //int sariRenk = (int)Enum.Parse(typeof(ConsoleColor), ConsoleColor.Yellow.ToString());
            //Console.WriteLine($"sarı renk enum kodu={sariRenk}");
            //int kirmiziRenk = (int)ConsoleColor.Red; --> integer'a dönüştürmenin CASTING ile daha kısa yoludur.

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Sarı renk enum kodu={sariRenk}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"kırmızı renk enum kodu={kirmiziRenk}");


            Console.WriteLine("------------");
            // Enumarationın sahip olduğu sayısal değere CASTING işlemi yaparak ataması yapıyoruz.
            Console.ForegroundColor = (ConsoleColor)5;
            
            Console.WriteLine("Enumarationın sahip olduğu sayısal değere CASTING işlemi yaparak Console rengini magenta yaptım.");


            Console.ReadKey();

        }
    }
}