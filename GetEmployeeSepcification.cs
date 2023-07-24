namespace SpecificationPattern
{
    public class GetEmployeeSepcification
    {
        public static List<Employee> GetEmployeeBy(IEmployeeSpecification specification, Employee[] employees)
        {
            List<Employee> NeededEmployees = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (specification.IsSatisfiedBy(employee))
                {
                    NeededEmployees.Add(employee);
                }
            }
            return NeededEmployees;
        }
    }
}
