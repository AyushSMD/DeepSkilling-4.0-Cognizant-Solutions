using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger instance;
        private static readonly object lockObj = new object();

        private Logger()
        {
            Console.WriteLine("New instance created.");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Logged message : {message}");
        }
    }
}