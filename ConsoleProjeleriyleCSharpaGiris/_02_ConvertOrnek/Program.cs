namespace _02_ConvertOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Amaç convert ile sharptaki tiplere dönüşüm sağlayabiliriz. Convert kelimesinin üzerine gelip F12'ye basınız.
            // ya da Convert kelimesinin tam üzerine gelip sağ tıkla goto defination diyerek Convert sınıfının (sınıfları oopta öğrenceğiz)
            //içinde To ile başlayan bir çok tipe dönüşüm imkanı verdiğini inceleyiniz.
            //Örn ToDateTime ToBoolean
            // Kullandıkça oturacaktır. Acele etmeyelim. Nerdeyse tüm örneklerde convert ya da onun akrabası olan başka bir dönüştürücü olacaktır.
            //Soru: Neden Converte ihtiyaç duymaktayız ki ?

            //sonuç virgüllü geliyor. 4 integerdır ama sonucun istediğim tipte gelmesini istediğim için Convert ile decimal'e çevirdik.
            decimal sonuc = Convert.ToDecimal((4 + 10.0) / 4);
            Console.WriteLine(sonuc);



            Console.ReadKey();
        }
    }
}