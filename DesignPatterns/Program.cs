using DesignPatterns.Patterns;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory
                .Initialize()
                .CreateEmployee(Employee.Permanent, 100);

            AbstractFactory
                .Initialize(BrandType.Nokia)
                .GetSmartPhone()
                .GetModelSpecification();

            Console.Write(Singleton.Instance.Counter);
            Console.Write(Singleton.Instance.Counter);
        }
    }
}
