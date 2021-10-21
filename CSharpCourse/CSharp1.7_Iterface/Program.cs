using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_Iterface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager person = new PersonManager();
            person.Add(new Studet {Id=3,GNO=3,Name="Yunus",Surname="Mersinli" });
            person.Add(new Worker {Id=2,Name="fatih",Maas=3000,Surname="Mersinli"});

            Console.ReadLine();
        }
        


    }
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
    class Studet : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GNO { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Maas { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Isim :{0} , tipi : {1} ", person.Name,person.GetType().Name);
        }




    }
    
}
