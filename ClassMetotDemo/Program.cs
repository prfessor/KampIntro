using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager manager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Ad = "Oğuzhan";
            musteri1.Soyad = "İzgi";
            musteri1.CardNo = 789;
            musteri1.Id = 123456;

            musteri2.Ad = "Emir";
            musteri2.Soyad = "Yılmaz";
            musteri2.Id = 567890;
            musteri2.CardNo = 456;

            musteri3.Ad = "Erhan";
            musteri3.Soyad = "Genç";
            musteri3.Id = 7836458;
            musteri3.CardNo = 915;
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
           
            manager.Ekle(musteri1);
            manager.Ekle(musteri2);
            manager.Ekle(musteri3);

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            manager.MusterileriListele(musteriler);

           


            

        }  
    }
}
