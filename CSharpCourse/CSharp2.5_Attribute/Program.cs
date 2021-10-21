using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2._5_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1, Name = "Yunus", Surname = "Mersinli"};
            CustomerDal customerDal = new CustomerDal();
            //methodu cagırıyorken uzerinde obselete kullandığım için mesaj çıkartır !
            //customerDal.Add(customer);
            customerDal.AddNew(customer);
            Console.ReadLine();
        }

        class Customer
        {
            [RequiredProperty]
            public int Id { get; set; }
            [RequiredProperty]
            public string Name { get; set; }
            [RequiredProperty]
            public string Surname { get; set; }
        }
        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple = true) ]
        class RequiredProperty : Attribute
        {

        }

        class CustomerDal
        {
            [Obsolete("Dont use please use AddNew")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0} Eklendi ",customer.Name);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0} Eklendi ", customer.Id);
            }
        }
    }
}
