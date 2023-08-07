using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] ogrenciler = new string[4];
            //ogrenciler[0] = "zeynep";
            //ogrenciler[1] = "ayse";
            //ogrenciler[2] = "ali";
            //ogrenciler[3] = "ugur";

            //Console.WriteLine("1.)" + ogrenciler[0]);
            //Console.WriteLine("2.)" + ogrenciler[1]);
            //Console.WriteLine("3.)" + ogrenciler[2]);
            //Console.WriteLine();

            //for (int  i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine((1 + i) + ") " + ogrenciler[i]);
            //}

            //***
            //int[] sayilar = new int[4];
            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;
            //sayilar[3] = 14;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //***
            //decimal[] ondalikSayilar = new decimal[]
            //{
            //    9.9M,
            //    8.8M,
            //    7.7M,
            //    6.6M,

            //};

            //for (int  i = 0; i < ondalikSayilar.Length; i++)
            //{
            //    Console.WriteLine(ondalikSayilar[i]);
            //}

            //***
            //char[] isim = {'l','o','v','e' };

            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(isim[i]);
            //}

            string isim = "zeynep";

            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }



            Console.Read();
        }
    }
}
