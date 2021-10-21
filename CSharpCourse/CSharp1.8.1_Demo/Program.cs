using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8._1_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerManager loggerManager = new LoggerManager();
            ILogger[] loggers = new ILogger[3] {new FileLogger(), new SmsLogger(), new DatabaseLogger() };
            foreach (var item in loggers)
            {
                loggerManager.Logla(item);
            }
            
            Console.ReadLine();
        }
    }

    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Database logger!");    
        }
    }
    class FileLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("File logger!");
        }
    }

    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Sms logger!");
        }
    }
    class LoggerManager
    {

        public void Logla(ILogger logger)
        {

            logger.log();

        }

    }


    interface ILogger
    {
        void log();
    }
}
