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

            //int[] sayi = { 5, 8, 3, 1 };

            //int deger = 645648451;

            //Console.WriteLine(sayi[3]);

            //Random rnd = new Random();           

            //int[] sayilar = new int[100];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(500);
            //}
            //Array.Sort(sayilar);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}




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

            //Console.WriteLine("Kaç adet isim girmek istiyorsunuz?");
            //byte adet = byte.Parse(Console.ReadLine());

            //string[] isimler = new string[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine($"{i + 1}.İsim Giriniz:");
            //    isimler[i] = Console.ReadLine();
            //}
            //Array.Sort(isimler);
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}


            //for (int i = 1; i < 50; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //*
            //**
            //***
            //****
            //*****


            //Random rnd = new Random();

            //int[,] dizi = new int[3, 2];



            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        dizi[i, j] = rnd.Next(50);
            //    }
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(dizi[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Satır sayısı giriniz:");
            int satir = int.Parse(Console.ReadLine());
            Console.WriteLine("Sütun sayısı giriniz:");
            int sutun = int.Parse(Console.ReadLine());

            string[,] yildiz = new string[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    yildiz[i, j] = (i + j) % 2 == 0 ? "*" : " ";
                    Console.Write(yildiz[i,j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
