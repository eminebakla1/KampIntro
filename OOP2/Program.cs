using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Emine";
            musteri1.Soyadi = "Bakla";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TüzelMüsteri musteri2 = new TüzelMüsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();//bir yerde new görürsen bu bellekteki referans nosu
            Musteri musteri4 = new TüzelMüsteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            

            
        }
    }
}
