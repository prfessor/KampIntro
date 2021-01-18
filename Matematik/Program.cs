using System;

namespace Matematik
{
    class Program
    {
        //private static int result;

        static void Main(string[] args)
        {
            

            int number11 = 20;
            int number2 = 100;
            var result2 = Add3(ref number11, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number11);
            
            
            
            //int number22 = 1100;
            int number22;
            int number33= 1200;     
            var result3 = Add4(out number22, number33);         //buradaki ref ibaresi number1 ile beraber                                                               //number11 i de değiştirdi. çünkü "var result"
            Console.WriteLine(result3);                         //satırında fonksiyonun içine atılan number11, yalnız 
                                                                //değeriyle değil, adıyla yani referansıyla girmiş oldu.
                                                                //referans tip oldu yani.
                                                                //bu sayede de fonksiyonun içinde number1 in 20 den 30 a değişmesi
                                                                //number1 referansını ve oradan da sonucunu etkiledi.
            Console.WriteLine(number22);                        

            static int Add3(ref int number1, int number2)       // out keywordu ise reften farklı olarak dışardaki bağımsız 
            {                                                   //değer tipin belirli bir sayı değeri olmasını zorunlu kılmaz,
                number1 = 30;                                   //voidden gelen referans sayı ona yeter. Ama bu keywordde voidden referans 
                return number1 + number2;                       //gelmesi zorunludur.
                 
            }

            static int Add4(out int number22, int number33)
            {
                number22 = 7000;
                return number22 + number33;

            }



            

        }
    }
}

