using HRAdminstrationAPI;
using System.Numerics;
using static SchoolHRAdminstration.Program;

namespace SchoolHRAdminstration
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            //SeedData(employees);
            
            //foreach (var employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}
            //Console.WriteLine($" Total Annual Salaries (including bonus):{totalSalaries}");

            Console.WriteLine($" Total Annual Salaries (including bonuss):{employees.Sum(x=>x.Salary)}");

            var result= EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher,1,"Harun","Edoğan",1200);

            Console.ReadKey();
        }
      
       
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Fisher",
                Salary = 40000,
            };
            employees.Add(teacher1);
            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Tomas",
                Salary = 40000,
            };
            employees.Add(teacher2);
            IEmployee headOfDepartmans = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Branda",
                LastName = "Mullins",
                Salary = 50000,
            };
            employees.Add(headOfDepartmans);

            IEmployee debutyHeadMaster = new DebutyHeadMaster
            {
                Id = 4,
                FirstName = "Devlin",
                LastName = "Brown",
                Salary = 50000,
            };
            employees.Add(debutyHeadMaster);


            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "Damien",
                LastName = "Jones",
                Salary = 80000,
            };
            employees.Add(headMaster);

        }
    }
    public enum EmployeeType
    {
        Teacher, HeadOfDepartment, DebutyHeadMaster, HeadMaster
    }
    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }

    }

    public class DebutyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }

    }

    public class HeadMaster :EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }

    }

    public static class EmployeeFactory
    {
        public static IEmployee GetEmployee()
        {
            return new Teacher();
        }
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id
            , string firstName, string lastName, decimal salary)
        {
            IEmployee? employee = null;
            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPatern<IEmployee, Teacher>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                case EmployeeType.DebutyHeadMaster:
                    employee = new DebutyHeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };

                    break;
                case EmployeeType.HeadMaster:
                    employee = new HeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };

                    break;
                default:
                    break;
            }
            return employee;
        }
    }
}