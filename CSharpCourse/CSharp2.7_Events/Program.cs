using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2._7_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(55);
            Product mouse = new Product(26);

            harddisk.ProductName = "Hard Disk";
            mouse.ProductName = "Mouse";
            mouse.StockControlEvent += Mouse_StockControlEvent;


            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(20);
                Console.WriteLine("{0} ürününden {1} adet kaldı", harddisk.ProductName,harddisk.Stock);
                mouse.Sell(10);
                Console.WriteLine("{0} ürününden {1} adet kaldı",mouse.ProductName,mouse.Stock);
                Console.ReadLine();
            }
            Console.ReadLine();


        }

        private static void Mouse_StockControlEvent()
        {
            Console.WriteLine("mouse bitmek üzere dikkat edin !!!!!!!!!!!!!");
        }
    }
}
