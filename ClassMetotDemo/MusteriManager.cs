using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusterileriListele(Musteri[] musteriler) //class methoduna liste gönderme
        {
            foreach (Musteri musteri_i in musteriler)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("                                               ");
                Console.WriteLine($"AD : {musteri_i.Ad} ");
                Console.WriteLine($"SOYAD : {musteri_i.Soyad}");
                Console.WriteLine($"ID : {musteri_i.Id}");
                Console.WriteLine($"KART NUMARASI : {musteri_i.CardNo}");
                Console.WriteLine("                                               ");
                Console.WriteLine("-----------------------------------------------");
                

            }

        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"Sayın {musteri.Ad} {musteri.Soyad}, isminiz müşteri listesine eklendi." +
                $"Keyifli alışverişler dileriz. \n                                                    " +
                $"\nKart Numaranız : {musteri.CardNo}\nID'niz : {musteri.Id}");
            
            Console.WriteLine("------------------------------------------------------");
        
        }




        }
}
