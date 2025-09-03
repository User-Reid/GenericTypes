var employees = new List<Employee> {
  new Employee("Jake Smith", "Spoon Inspection", 25000),
  new Employee("Anna Blake", "Spoon Inspection", 29000),
  new Employee("Barbara Oak", "Xray", 21500),
  new Employee("Damien Parker", "Xray", 22000),
  new Employee("Nisha Patel", "Monkey Shit Removal", 21000),
  new Employee("Gustavo Sanchez", "Monkey Shit Removal", 20000),
};

var taco = CalculateAverageSalaryPerDepartment(employees);

Console.ReadKey();

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
  var employeesPerDepartments = new Dictionary<string, List<Employee>>();

  foreach (var employee in employees)
  {
    if (!employeesPerDepartments.ContainsKey(employee.Department))
    {
      employeesPerDepartments[employee.Department] = new List<Employee>();
    }
    employeesPerDepartments[employee.Department].Add(employee);
  }

  var result = new Dictionary<string, decimal>();

  foreach (var employeesPerDepartment in employeesPerDepartments)
  {
    decimal sumOfSalaries = 0;

    foreach (var employee in employeesPerDepartment.Value)
    {
      sumOfSalaries += employee.MonthlySalary;
    }

    var average = sumOfSalaries / employeesPerDepartment.Value.Count();

    result[employeesPerDepartment.Key] = average;
  }
  return result;
}

public class Employee
{
  public string Name { get; }
  public string Department { get; }
  public decimal MonthlySalary { get; }
  public Employee(string name, string department, decimal monthlySalary)
  {
    Name = name;
    Department = department;
    MonthlySalary = monthlySalary;
  }
}