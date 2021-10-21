using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();

            Console.WriteLine(topla(7, 8));
            int sayi = 10;
            Console.WriteLine("degerdeistiren methodundan önce : {0}", sayi);
            degerDegistiren(ref sayi);
            Console.WriteLine("degerdeistiren methodundan sonra : {0}", sayi);
            Console.WriteLine("default parametre : {0}", parametredefault(1));
            Console.WriteLine("2 parametreli method ile carpım {0}", Multiply(2, 3));
            Console.WriteLine("3 parametreli method ile carpım {0}", Multiply(2, 3, 4));

            Console.WriteLine("istenilen kadar sayıyı çarpma : {0}", carpici(1, 2, 3, 4, 5));



            Console.ReadLine();

        }

        //------------------------------parametresiz method
        static void Hello()
        {
            Console.WriteLine("Merhaba len");
        }
        //------------------------------parametreli method
        static int topla(int a, int b)
        {
            return a + b;
        }
        //ref olarak gönderince dışardaki degerini degistirebiliyorum yoksa this gibi parametre içindeki degeri default deyistiriyor.
        static int degerDegistiren(ref int sayi)
        {
            return sayi = 0;
        }
        //------------------------------Default parametreli method
        static int parametredefault(int a = 0, int b = 2)
        {
            return a + b;

        }
        //------------------------------Method overloading
        static int Multiply(int a, int b)
        {
            return a * b;

        }
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;

        }
        //------------------------------methoda dizi halinde parametre gönderme
        static int carpici(params int[] numbers)//sayilari bir integer dizi oalark gönderip for ile içinde gezdim
        {
            int result = 1;

            foreach (var item in numbers)
            {
                result *= item;
            }
            return result;

        }



    }
}
