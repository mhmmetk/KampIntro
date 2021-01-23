using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //engin demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "1233456857";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "65878";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12528484885";

            //gerçek müşteri - tüzel müşteri
            //SOLID L harfi bunu söylüyor

            Musteri musteri3 = new GercekMusteri();//new=referans no
            Musteri musteri4 = new TuzelMusteri();//new=referans no

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
