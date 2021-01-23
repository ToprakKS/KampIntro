using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12334241251";
            musteri1.Id = 1;


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "542234";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234325121";
            musteri2.Id = 2;

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            
            
            
        }
    }
}

//musteri1.Adi = "Toprak";
//musteri1.Soyadi = "Sevim";
//musteri1.Id = 1;
//musteri1.TcNo = "21231214124";
//musteri1.MusteriNo = "123456";
//musteri1.SirketAdi = "?";

//Gerçek Müşteri - Tüzel Müşteri
//SOLID
