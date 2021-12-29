﻿using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //ekrana girilen sayıya kadar olan tek sayılarını ekrana yazdırır.
            Console.WriteLine("lütfen bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i=1; i<=sayac; i++){
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 100 arasındaki tek ve çift sayıların kendi içlerinde toplamını ekrana yazdırır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i =1; i <= 100; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            //break, continue

            for (int i =1; i<10; i++)
            {
                if(i==4)
                 break;
                Console.WriteLine(i);
            }

            for (int i =1; i<10; i++)
            {
                if(i==4)
                 continue;
                Console.WriteLine(i);
            }

        }
    }
}
