using DesignPatterns.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static Factory factory = new Factory();
        
        static void Main(string[] args)
        {
            factory.Init();
        }
    }
}
