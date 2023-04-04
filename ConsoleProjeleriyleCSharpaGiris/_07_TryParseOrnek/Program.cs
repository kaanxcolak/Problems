namespace _07_TryParseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek: Dolar kuru

            double miktarUSD = 0;
            double dolarKuru = 0;
            double sonuc = 0;

            Console.WriteLine("Dolar kuru giriniz: ");
            double.TryParse(Console.ReadLine(), out dolarKuru);
            // double.Tryparse yani double dönüştürmeya uğraş
            // yapabilirse dönüştürdğünü out ile keywordü aracılığıyla dışarıdaki değişkene aktar.
            Console.WriteLine("Kaç dolarınız var? :   ");
            double.TryParse(Console.ReadLine(), out miktarUSD);
            sonuc = miktarUSD * dolarKuru;
            Console.WriteLine($"{dolarKuru} * {miktarUSD} = {sonuc} TL paranız var.");
            // String ifadeleri 3 şekilde yazabiliriz
            // 1--> + operatörleri ile stringleri birleştirebiliriz
            // 2 --> string format ile yazabilirsiniz.
            // 3--> string formatın $ işareti haliyle.
            Console.ReadKey();
        }
    }
}