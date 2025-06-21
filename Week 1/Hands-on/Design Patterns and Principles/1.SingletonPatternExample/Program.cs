using System;
using SingletonPatternExample;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("First log message.");
            logger2.Log("Second log message.");

            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Both are the same instance. Singleton success.");
            }
            else
            {
                Console.WriteLine("Both have different instences. Singleton failed.");
            }
        }
    }
}