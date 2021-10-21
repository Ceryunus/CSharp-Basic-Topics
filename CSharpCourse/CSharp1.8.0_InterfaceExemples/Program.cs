using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8_InterfaceExemples
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabeseAdd();
            //AllDBAdd();
            //AllDBAllMethods();

            Console.ReadLine();


            void DatabeseAdd()
            {
                DatabaseManagerDal databaseManager = new DatabaseManagerDal();
                databaseManager.Add(new Oracle());
            }

            void AllDBAllMethods()
            {
                DatabaseManagerDal database = new DatabaseManagerDal();
                IDatabase[] databases = new IDatabase[3]{
              new Oracle(),
              new MySql(),
              new MSSQL(),
            };
                foreach (var db in databases)
                {
                    database.Add(db);
                    database.Delete(db);
                    database.Update(db);
                }
            }
        }

        private static void AllDBAdd()
        {
            IDatabase[] databases = new IDatabase[3]{
            new Oracle(),
            new MySql(),
            new MSSQL()
            };
            DatabaseManagerDal database = new DatabaseManagerDal();
            foreach (var db in databases)
            {
                database.Add(db);
            }
        }
    }

}
