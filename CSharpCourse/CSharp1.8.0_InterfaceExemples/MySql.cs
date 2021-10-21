using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8_InterfaceExemples
{
    class MySql : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("MySql eklendi !");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted !");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated!");
        }
    }
}
