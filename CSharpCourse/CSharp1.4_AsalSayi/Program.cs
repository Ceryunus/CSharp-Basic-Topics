using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            isprime(sayi);
            Console.ReadLine();
        }
        //asal sayıyı bir method olarak yapıp sonradan main fonksiyonunun içinde çağırdım .
        static void isprime(int num)
        {
            bool isPrime = true;

            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("Sayi asal");
            }
            else
            {
                Console.WriteLine("Sayi asal degil");
            }
        }
    }
}
