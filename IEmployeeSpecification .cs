namespace SpecificationPattern
{
    public interface IEmployeeSpecification
    {
        bool IsSatisfiedBy(Employee employee);
    }

    public class EmployeeDepartmentSpecification : IEmployeeSpecification
    {
        private readonly string _department;

        public EmployeeDepartmentSpecification(string depatrment)
        {
            _department = depatrment;
        }

        public bool IsSatisfiedBy(Employee employee)
        {
            return employee.Department.Equals(_department);
        }
    }

    public class EmployeeYearSpecification : IEmployeeSpecification
    {
        private readonly int _year;

        public EmployeeYearSpecification(int year)
        {
            _year = year;
        }
        public bool IsSatisfiedBy(Employee employee)
        {
            return employee.YearOfResumption.Equals(_year);
        }
    }
}
