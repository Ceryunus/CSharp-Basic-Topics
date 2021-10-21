using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ornek 1
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.write();

            //ornek 2

            EmployeeManager employeeManager = new EmployeeManager("Selam");
            employeeManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int count;
        public CustomerManager(int count)
        {
            this.count = count;
            
        }
         public void write() {
            Console.WriteLine("count {0}", count);
        }
    }
    //temel sınıfın yapıcı bloğuna parametre yollamak 
    class BaseClass
    {
        private string message;
        
        public BaseClass(string message)
        {
            this.message = message;

        }
        public void Message() {
            Console.WriteLine("{0} Massage !!!",message);


        }
    }
    class EmployeeManager : BaseClass
    {
        //constructer ile beraber base classın yapıcı metoduna parameter gönderdim.
        public EmployeeManager(string message) : base(message)
        {

        }
        public void Add() {
            Console.WriteLine("Added!");
            Message();
                }   

    }
}
