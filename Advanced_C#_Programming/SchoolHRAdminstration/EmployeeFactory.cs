using HRAdminstrationAPI;

namespace SchoolHRAdminstration
{
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
                    employee = FactoryPatern<IEmployee, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.DebutyHeadMaster:
                    employee = FactoryPatern<IEmployee, DebutyHeadMaster>.GetInstance();

                    break;
                case EmployeeType.HeadMaster:
                    employee = FactoryPatern<IEmployee, HeadMaster>.GetInstance();

                    break;
                default:
                    break;
            }
            if (employee is not null)
            {
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Salary = salary;
            }
            else
                throw new NullReferenceException();

             
            return employee;
        }
    }
}