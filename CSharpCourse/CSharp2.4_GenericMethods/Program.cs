using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2._4_GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //genreic aslında paramter kullanarak tip belirtme işlemi <T> şeklinde genellikle kullanılır.
            //Methodlarda generic methodları kullanark verilen liste türüne göre liste oluşturma !
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<String>("Ankara", "Adana", "İstanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "yunus" }, new Customer { FirstName = "Fatih" });
            foreach (var item2 in result2)
            {
                Console.WriteLine(item2.FirstName);
            }
            Console.ReadLine();
        }
       class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }
        
        //-----------Classlarda generic method kullanımına bir örnek
        class Customer
        {
            public string FirstName { get; set; }

        }
        class Product
        {

        }
        interface ICustomerDal:IRepostory<Customer>
        {

        }
        interface IProductDal:IRepostory<Product>
        {

        }
        interface IRepostory<T>
        {
            List<T> GetAll();
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);

        }
        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}
