using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ?? = 30 // sayısal veriler:int,double,float,decimal,bool tipler değer tiplerdir.

            int[] sayilar = new int[] { 12, 34, 676 };
            int[] sayilar2 = new int[] { 90, 80, 50 };
            sayilar = sayilar2;
            sayilar2[0] = 150;  //array,class,interface referans tiplerdir.
            //sayilar[0] = ??
        }
    }
}

// bellekteki alanlar:
//          1. STACK                        2. HEAP
//          
//      SAYİ1 = 10
//      sayi2 = 30
//  sayi1 = sayi2; bu ifadede sadece
//  sayi2 nin "değeri" alınır ve sayi2 
//  ile irtibat kopar. sayi2 nin 65 olması 
//  sayi1 i etkilemeyecektir.
//
//-------------------------------------
//      sayilar1      ==           [ 12, 34, 676 ](buna bellekte bir isim   
//                                  verilir. örn 101
//      sayilar2      ==           [ 90, 80, 50 ] (buna da isim verilir (102))
//      sayilar1 = sayilar2 ::: bu ifade, iki array eşitlemenin yanında
//      ikisinin referans değerlerini de "102" ye eşitler. sayilar1 listesinin
//      kendi eski elemanlarıyla işi kalmadı sadece sayilar2 ninkini tutuyor.