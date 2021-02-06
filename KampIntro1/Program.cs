using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safet y-tip güvenliği
            //Do not repeat yourself-Kendini tekrarlama
            //Değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmısMi ==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
