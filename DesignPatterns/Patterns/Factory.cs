using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns
{
    
    public class Factory
    {
        public static Factory Initialize() => new Factory();

        public IEmployee CreateEmployee(Employee employeeType, int salary)
        {
            var employees = new Dictionary<Employee, EmployeeFactory>() {
                {
                    Employee.Permanent, new PermanentEmployeeFactory()
                },
                {
                    Employee.Contract, new ContractEmployeeFactory()
                }
            };

            return employees[employeeType].Create(salary);
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
