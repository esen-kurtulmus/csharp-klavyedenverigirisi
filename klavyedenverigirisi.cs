using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birinciders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden veri girişleri
            string city, country;
            Console.Write("Lütfen şehir bilgisi giriniz: ");
            city = Console.ReadLine();
            Console.Write("Lütfen ülke bilgisi giriniz: ");
            country = Console.ReadLine();
            Console.WriteLine("yazdığınız şehir ve ülke :" + city + " " + country);
            Console.ReadLine();
            //dönüşüm
            int sayi;
            Console.Write("sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("girdiğiz sayı :" + sayi);
            Console.ReadLine();
            int sayi2;
            Console.Write("sayıyı giriniz:");
            sayi2 = Convert.ToInt16(Console.ReadLine());  //daha küçük sayılarda 16 kullanılır.
            Console.Write(sayi2);
            Console.ReadLine();
            double sayi3;
            Console.Write("sayıyı giriniz:");
            sayi3= Convert.ToDouble(Console.ReadLine());
            Console.Write(sayi3);
            

            Console.ReadLine();




        }
    }
}

