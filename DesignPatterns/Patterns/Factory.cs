using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DesignPatterns.Patterns
{
    public class Factory
    {
        public void Init()
        {
            var employees = new Dictionary<Employee, IEmployee>() {
                {
                    Employee.Permanent, new PermanentEmployeeFactory().Create(100)
                },
                {
                    Employee.Contract, new ContractEmployeeFactory().Create(50)
                }
            };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Key} - Salary {employee.Value.Salary}");
            }
        }
    }

    public enum Employee {
        Permanent,
        Contract
    }

    public abstract class EmployeeFactory
    {
        public abstract IEmployee Create(int salary);
    }

    public class PermanentEmployeeFactory : EmployeeFactory
    {
        public override IEmployee Create(int salary)
        {
            return new PermanentEmployee(salary);
        }
    }

    public class ContractEmployeeFactory : EmployeeFactory
    {
        public override IEmployee Create(int salary)
        {
            return new ContractEmployee(salary);
        }
    }

    public class PermanentEmployee : IEmployee
    {
        public int Salary { get ; set ; }

        public PermanentEmployee(int Salary)
        {
            this.Salary = Salary;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public int Salary { get; set; }

        public ContractEmployee(int Salary)
        {
            this.Salary = Salary;
        }
    }

    public interface IEmployee {

         int Salary { get; set; }
    }
}
