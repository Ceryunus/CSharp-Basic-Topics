using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2._7_Events
{
    public delegate void StockControl();

    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value<=15&&StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }
        public string ProductName { get; set; }

        public event StockControl StockControlEvent;
        

        


        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("stock : {0}",Stock);
        }
        


    }
}
