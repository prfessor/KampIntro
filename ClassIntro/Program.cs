using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();  //class için bir obje oluşturuldu.
            kurs1.KursAdi = "C#";  //objeye ait attributelar
            kurs1.Egitmen = "Engin Demiroğ"; //objeye ait attributelar
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();  //class için bir obje oluşturuldu.
            kurs2.KursAdi = "Java";  //objeye ait attributelar
            kurs2.Egitmen = "Kerem Varış"; //objeye ait attributelar
            kurs2.IzlenmeOrani =64;

            Kurs kurs3 = new Kurs();  //class için bir obje oluşturuldu.
            kurs3.KursAdi = "Python";  //objeye ait attributelar
            kurs3.Egitmen = "Berkay Bilgin"; //objeye ait attributelar
            kurs3.IzlenmeOrani = 80;

            Console.WriteLine(kurs1.Egitmen + " : " + kurs1.KursAdi);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }



        }
        class Kurs //kurs classı oluşruldu.
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }

            public int IzlenmeOrani { get; set; }
        }

    }
}
