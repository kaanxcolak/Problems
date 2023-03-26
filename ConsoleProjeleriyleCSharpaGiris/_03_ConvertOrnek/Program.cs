namespace _03_ConvertOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORU: NEDEN CONVERT ETMEK ZORUNDAYIM ?
            //Sebep 1: C# tip bağımlı bir dildir. Bu nedenle herkes kendi tipine uygun atamalara sahip olmak zorundadır.
            //Sebep 2: Kullanıcıdan sayı istediniz ama kullanıcı yanlışlıkla 20, yazdı. 20, bir sayı mıdır? HAYIR! 
            //Son anda eli yanlışlıkla virgüle tıklamış... Böyle bir durumda 20, 'ü nasıl integer tipte bir değişkene atayabiliriz?
            //Atamada sorun çıkacaktır

            Console.WriteLine("Bir sayı giriniz    : ");
            //Sizden sayı istediğinde 20, 'e basınız. ya da rakam harici klayeden farklı karakterelere basınız. Programınız patlayacaktır.
            // System.InvalidCastException isimli bir hata aldınız. Ne demek bu?
            //Yazdığın şeyin integer'a dönüşümü asla mümkün değil demektir.
            //Bu durumda Convert demekki yaramaz kullanıcılarım olursa beni patlatıyor.
            //Peki ne yapacağım ?? Ayrıca belki kullanıcı yaramaz değildi. Yanlışlıkla rakam harici bir tuşa bastı...
            //Ne olacak şimdi??
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teşekkürler");


            Console.ReadKey();

        }
    }
}