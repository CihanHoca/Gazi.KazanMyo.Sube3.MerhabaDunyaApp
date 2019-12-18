using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Sube3.DizilerApp
{
    class Program
    {
        static void Main(string[] args)
        {//Array
            // int[] sayilar = { 3, 6, 8, 4 };

            //int[] sayilar = new int[3];

            //sayilar[0] = 5;
            //sayilar[1] = 3;
            //sayilar[2] = 15;

            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);

            //Array.Sort(sayilar);


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            Console.WriteLine("Kaç adet isim girmek istiyorsunuz?");
            byte adet = byte.Parse(Console.ReadLine());

            string[] isimler = new string[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine($"{i+1}.İsim Giriniz:");
                isimler[i] = Console.ReadLine();
            }
            Array.Sort(isimler);
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }            

            Console.ReadKey();
        }
    }
}
