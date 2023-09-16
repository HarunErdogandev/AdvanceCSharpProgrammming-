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
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", 40000);
            employees.Add(teacher1);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny", "Tomas", 40000);
            employees.Add(teacher2);

            IEmployee headOfDepartmans = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Branda", "Mullins", 50000);
            employees.Add(headOfDepartmans);

            IEmployee debutyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DebutyHeadMaster, 4, "Devlin", "Brown", 60000);
            employees.Add(debutyHeadMaster);

            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Damien", "Jones", 80000);
            employees.Add(headMaster);

        }
    }
}