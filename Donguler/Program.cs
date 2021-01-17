using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine("sayı: " + i);
            }
            string []kurslar = new string[] {"Yazılım geliştirici kursu", 
                "programlam başlangıcı","java kursu"};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            {

            }
        }
    }
}
