namespace SpecificationPattern
{
    public class GetEmployee
    {
        Employee[] employees = new Employee[] {
            new Employee { FirstName = "Fidel", Department = "Maths", YearOfResumption = 2017 },
            new Employee { FirstName = "Francis", Department = "Software", YearOfResumption = 2018 },
            new Employee { FirstName = "Ahmed", Department = "Maths", YearOfResumption = 2018 },
            new Employee { FirstName = "Ebuka", Department = "Software", YearOfResumption = 2017 }
        };

        public Employee[] GetEmployeesByName(string name)
        {
            return employees
                .Where(x => x.FirstName == name)
                .ToArray();
        }

        public Employee[] GetEmployeesByDepartment(string department)
        {
            return employees
                .Where(x => x.Department == department)
                .ToArray();
        }

        public Employee[] GetEmployeesByID(string id)
        {
            return employees
                .Where(x => x.EmployeeID == id)
                .ToArray();
        }

        public Employee[] GetEmployeesByYear(int year)
        {
            return employees
                .Where(x => x.YearOfResumption == year)
                .ToArray();
        }
    }
}
