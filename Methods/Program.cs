using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product []  { urun1,urun2};

            foreach (Product urun in urunler)  //belli classdaki objeleri döndürür; product class, urun dondurme elemanı, urunler product için oluşturulan array
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("-------------------------METHODS---------------------------");

            ChartManager chart = new ChartManager();
            chart.AddChart(urun1);  //addcharttaki productın bir objesini burada da içeri yazıyoruz
            chart.AddChart(urun2);
            //başka zaman consoel ifadesi değiştirdiğimiz zaman heğsinde değişecektir. 


            chart.AddChart2("armut", "yeşil armut", 12,20);  //urundekiler yerine attributeları kendimiz girdik
            chart.AddChart2("elma", "amasya", 12,30);
            chart.AddChart2("karpuz", "diyarbakır", 12, 50);


        }
    }
}

//do not repeat yourself