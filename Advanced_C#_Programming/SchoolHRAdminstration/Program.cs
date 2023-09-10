using HRAdminstrationAPI;

namespace SchoolHRAdminstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            //foreach (var employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}
            //Console.WriteLine($" Total Annual Salaries (including bonus):{totalSalaries}");

            Console.WriteLine($" Total Annual Salaries (including bonuss):{employees.Sum(x=>x.Salary)}"); 



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
}