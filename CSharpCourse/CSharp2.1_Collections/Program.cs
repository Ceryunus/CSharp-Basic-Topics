using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //collections yani ArrayListler(type guvenli degil!)
            //ArrayList();
            //List type guvenli istenilen type baska type alamaz
            //MyList();
            //List kullanım alanı daha çok bir classın türünde oluyor.
            //ListOperations();
            //Sozlukler key value degerleri iöerisnde barındaran collectionslar
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("man","adam");
            dictionary.Add("woman","kadin");
            dictionary.Add("bone","kemik");
            foreach (var VARIABLE in dictionary)
            {
            Console.WriteLine(VARIABLE);
            Console.WriteLine(VARIABLE.Value);
            Console.WriteLine(VARIABLE.Key);

            }
            Console.ReadLine();
           









            void ArrayList()
            {
                ArrayList myArrylist = new ArrayList();
                myArrylist.Add("Trabzon");
                myArrylist.Add("Antalya");
                myArrylist.Add(61);
                myArrylist.Add(7);
                myArrylist.Add('T');
                foreach (var item in myArrylist)
                {
                    Console.WriteLine(item);
                }

            }
        }

        private static void ListOperations()
        {
            //listeye eleman eklemenin 1. yontemi
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "yunus"},
                new Customer {Id = 2, Name = "fatih"},
                new Customer {Id = 3, Name = "kadir"}
            };
            //listeye eleman eklemenin 2. yontemi
            var father = new Customer() {Id = 4, Name = "Bahittin"};
            customers.Add(father);
            //listeye eleman eklemenin 3. yontemi burada bir dizi olarak eklememiz gerekiyor
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 5, Name = "iso"},
                new Customer {Id = 6, Name = "mun"}
            });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name);
            }

            //litedeki eleman sayınsını verir
            var count = customers.Count;
            Console.WriteLine(count);
            //istenilen indexteki elemanı kaldırma
            customers.Remove(customers[2]);
            //listeyi temizler
            customers.Clear();
            //elemanın kaçıncı indexde olduğunu gösterir
            var index = customers.IndexOf(father);
            Console.WriteLine("{0}.Index", index);
            //istenilen indexe deger verme
            customers.Insert(1, father);
            //
        }

        private static void MyList()
        {
            List<String> cities = new List<string>();
            cities.Add("Trabzon");
            cities.Add("Antalya");
            //cities.Add(1); Eklenemez!
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
