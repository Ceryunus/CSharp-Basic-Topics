using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8_InterfaceExemples
{
    class MSSQL : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("MSSQL eklendi !");
        }

        public void Delete()
        {
            Console.WriteLine("MSSQL deleted !");
        }

        public void Update()
        {
            Console.WriteLine("MSSQL updated !");
        }
    }
}
