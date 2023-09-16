using HRAdminstrationAPI;

namespace SchoolHRAdminstration
{
    public class DebutyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }

    }
}