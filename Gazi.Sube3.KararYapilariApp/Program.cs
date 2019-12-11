using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube3.KararYapilariApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1.Sayıyı giriniz:");
            //byte sayi1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı Giriniz:");
            //byte sayi2 = byte.Parse(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 Büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 2 büyük ya da sayılar eşit");
            //}
            //?:->[Koşul]?[true işlemi]:[false işlemi]
            //Ternary operator
            //Operand
            //sayi1+sayi2
            //Console.WriteLine(sayi1 > sayi2 ? "Sayı 1 Büyük" : "Sayı 2 büyük ya da sayılar eşit");

            //if (sayi1>sayi2)
            //{
            //    Console.WriteLine("Sayı 1 büyüktür");
            //}
            //else if(sayi2>sayi1)
            //{
            //    Console.WriteLine("Sayı 2 büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}

            // 1 && 1=1
            // 1 && 0=0
            // 0 && 0=0
            // 0 && 1=0

            // 1 || 1=1
            // 0 || 1=1
            // 1 || 0=1
            // 0 || 0=0

            //byte a = 10; string s;
            //byte b = 3, c = 20;
            //Console.WriteLine((!(a == b) && (b == 3)));

            //Case Sensitive            


            //Console.WriteLine("Hava Nasıl:");
            //string cevap = Console.ReadLine();
            //if (cevap.ToLower() == "güzel")
            //{
            //    Console.WriteLine("Kaç derece:");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece < 0)
            //    {
            //        Console.WriteLine("Çok soğuk");
            //    }
            //    else if (derece >= 0 && derece <= 15)
            //    {
            //        Console.WriteLine("Soğuk");
            //    }
            //    else if (derece > 15 && derece <= 35)
            //    {
            //        Console.WriteLine("Dışarı Çık");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Çok sıcak");
            //    }
            //}
            //else if (cevap.ToUpper()== "KÖTÜ")
            //{
            //    Console.WriteLine("Evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("Sadece güzel/kötü cevabı verebilirsiniz.");
            //}

            //Break Point
            Console.WriteLine("Bir sayı giriniz:");
            byte sayi = byte.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("1 değeri girildi");
                    break;
                case 2:
                    Console.WriteLine("2 değer girildi");
                    break;
                case 3:
                    Console.WriteLine("3 değeri girildi");
                    break;
                default:
                    Console.WriteLine("Farklı bir değer girildi");
                    break;
            }


            if (sayi==1)
            {
                Console.WriteLine("1 değeri girildi");
            }
            else if (sayi==2)
            {
                Console.WriteLine("2 değeri girildi");
            }
            else if (sayi==3)
            {
                Console.WriteLine("3 değeri girildi");
            }
            else
            {
                Console.WriteLine("Farklı bir değer girildi");
            }
            Console.ReadKey();

        }
    }
}
