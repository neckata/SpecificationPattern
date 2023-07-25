using SpecificationPattern;

Employee employee1 = new Employee { FirstName = "Fidel", Department = "Maths", YearOfResumption = 2017 };
Employee employee2 = new Employee { FirstName = "Francis", Department = "Software", YearOfResumption = 2018 };
Employee employee3 = new Employee { FirstName = "Ahmed", Department = "Maths", YearOfResumption = 2018 };
Employee employee4 = new Employee { FirstName = "Ebuka", Department = "Software", YearOfResumption = 2017 };

Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };

Console.WriteLine("Software Department");

List<Employee> SoftwareEmployees = GetEmployeeSepcification.GetEmployeeBy(new EmployeeDepartmentSpecification("Software"), employees);
foreach (var employee in SoftwareEmployees)
{
    Console.WriteLine(employee.FirstName);
}

Console.WriteLine();

Console.WriteLine("Employed in 2017");
List<Employee> EmployedIn2017 = GetEmployeeSepcification.GetEmployeeBy(new EmployeeYearSpecification(2017), employees);
foreach (var employee in EmployedIn2017)
{
    Console.WriteLine(employee.FirstName);
}

Console.WriteLine();

Console.WriteLine("Employed in Maths Department");
var specification = new GenericSpecification<Employee>(m => m.Department == "Maths");
var maths = employees.Where(specification.Expression.Compile()).ToList();
foreach (var employee in maths)
{
    Console.WriteLine(employee.FirstName);
}

Console.ReadKey();