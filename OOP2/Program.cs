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
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TüzelMüsteri müsteri2 = new TüzelMüsteri();
            müsteri2.Id = 2;
            müsteri2.MusteriNo = "54321";
            müsteri2.SirketAdi = "Kodlama.io";
            müsteri2.VergiNo = "1234567890";



            
            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID

            //51.31 5. ders
        }
    }
}
