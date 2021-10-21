using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2._6_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,4);
            //Console.WriteLine(dortIslem.topla(5, 6));
            //Console.WriteLine(dortIslem.topla2());
            var type = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,5,6);
            Console.WriteLine(dortIslem.topla(2,3));
            Console.WriteLine(dortIslem.topla2());

            var instance = Activator.CreateInstance(type, 8, 9);
            MethodInfo methodInfo = instance.GetType().GetMethod("topla2");
            methodInfo.Invoke(instance,null);
            Console.ReadLine();
        }

        class DortIslem
        {
            private int _sayi1;
            private int _sayi2;
            public DortIslem(int sayi1,int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public int topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;

            } 
            public int topla2()
            {
                return _sayi1 + _sayi2;
            }
            public int carp2()
            {
                return _sayi1 * _sayi2;

            }
            





        }
    }
}
