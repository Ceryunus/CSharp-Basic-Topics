using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8_InterfaceExemples
{
    class DatabaseManagerDal
    {
        public void Add(IDatabase database) {
            database.Add();
        }
        public void Delete(IDatabase database)
        {
            database.Delete();

        }
        public void Update(IDatabase database) {
            database.Update();
        }
    }
}
