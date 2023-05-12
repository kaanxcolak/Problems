namespace _02_IFOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char bankaTercihi = ' '; //char tipte değişkeni tanımlayıp varsayılan ilk değerini atadık
            //const ile sabit değişkenler tanımlanır. Yani değeri bir kere atanıp program boyunca değişmeyen değişkenlerdir
            const double AbankasiFaizOran = 1.5;
            const double BbankasiFaizOran = 0.99;
            const double standartFaizOran = 0.5;
            int anapara = 0;
            Console.Write("Banka seçiniz A/B:");
            bankaTercihi = Convert.ToChar(Console.ReadLine());
            Console.Write("Ana para giriniz   :");
            anapara = Convert.ToInt32(Console.ReadLine());  
            
        }
    }
}