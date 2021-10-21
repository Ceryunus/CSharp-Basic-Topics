using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8_InterfaceExemples
{
    class Oracle : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("oracle eklendi !");
        }

        public void Delete()
        {
            Console.WriteLine("oracle silindi !");
        }

        public void Update()
        {
            Console.WriteLine("oracle update !");
        }
    }
}
