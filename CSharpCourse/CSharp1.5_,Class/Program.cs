using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5__Class
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Customer customer = new Customer();
            customer.Name = "Yunus";
            customer.Age = 21;
            customer.SetLastname("Mersinli");




            Console.WriteLine("Name : {0} surname : {1} age : {2}", customer.Name,customer.GetLastname(),customer.Age);
            Console.ReadLine();

        }
    }
    class Customer
    {
        //----------Encapsulation

        public string Name { get; set; }
        private int age;
        public int Age { get => age; set => age = value; }
        //javada kullanıgım sekili
        private string lastname;

        public string GetLastname()
        {
            return lastname;
        }

        public void SetLastname(string value)
        {
            lastname = value;
        }
    }
}
