using System;

namespace Gazi.KazanMyo.Sube3.MerhabaDunyaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //const byte sayi=5;
            //Console.WriteLine(sayi);

            //var sayi = "5";//Implicit Tanımlama
            //byte _sayi = 5;//Explicit


            //string isim = "Ahmet";
            //string soyad = "Mehmet";

            //Console.WriteLine("Hoşgeldin " + isim + " " + soyad);
            //Console.WriteLine("Hoşgeldin {0} {1}", isim, soyad);
            //Console.WriteLine($"Hoşgeldin {isim} {soyad}");

            //Tip Güvenliği - Type Safety
            //byte sayibyte = 5;
            //int sayiint = sayibyte;
            //Tür Dönüşümü-Type Casting
            //byte->int
            //Implicit Type Casting - Bilinçsiz Tür Dönüşümü 


            //Explicit Type Casting - Bilinçli Tür Dönüşümü
            //Tür Dönüşümü Operatörü -> ()
            //Bu operatörle değer tipi->değer tipi
            //İstisna: Object Tipinden->Değer Tipine
            //Object Tipi C#'daki bütün tiplerin en üstündeki tiptir.Bu durumda bütün veri tipleri bir Objecttir.
            //Bu dönüşümlerde veri kaybı ihtimali var!


            //int sayint = 5;
            //object deneme = sayint;//Boxing
            ////Değer tipinden->Object Tipine dönüşüm boxing

            //int sayintt = (int)deneme;//Unboxing
            //Object tipinden tekrar değer tipine dönüşüm unboxing. 

            //checked
            //{
            //    int numberint = 258;
            //    byte numberbyte = (byte)numberint;
            //    Console.WriteLine(numberbyte); 
            //}

            //string str = "5";
            //byte sayi = byte.Parse(str);
            //int _sayi = int.Parse(str);
            ////Parse metodu sadece stringi ilgili türe dönüştürür.

            //byte __sayi = Convert.ToByte(str);
            //Convert class'ındaki metodlar, tüm tipleri ilgili tiplere dönüştürür.

            // Console.WriteLine(sayi);

            //Değişiklik
            try
            {               
                Console.WriteLine("Adınızı giriniz:");
                string ad = Console.ReadLine();
                Console.WriteLine("Soyadınızı giriniz:");
                string soyad = Console.ReadLine();
                Console.WriteLine("Yaşınızı giriniz:");
                byte yas = byte.Parse(Console.ReadLine());
                Console.WriteLine($"Adınız:{ad}\nSoyadınız:{soyad}\nYaşınız:{yas}");
            }            
            catch (OverflowException)
            {
                Console.WriteLine("0-255 arası gir");
            }           
            catch (Exception ex)
            {                
                Console.WriteLine($"Bir hata oluştu.\nTarih:{DateTime.Now}\nStack Trace:{ex.StackTrace}\n{ex.GetType()}");
            }
            Console.ReadKey();
        }
    }
}
