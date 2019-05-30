using System;

namespace DesignPatterns.Patterns
{
    public class Singleton
    {
        private int _counter = 0;

        private Singleton()
        {
            Console.Write("Initialized");
        }

        public int Counter {
            get
            {
                return _counter++;
            }
        }

        public static Singleton Instance = new Singleton();
    }
}
