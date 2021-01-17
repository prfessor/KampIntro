using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class ChartManager
    {
        public void AddChart(Product urun)  //içindekinin verilerini kullanmak için product classını ekledik
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi);
        }

        public void AddChart2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : "+ urunAdi);
        }


        }
    }

