var employees = new List<Employee> {
  new Employee("Jake Smith", "Spoon Inspection", 25000),
  new Employee("Anna Blake", "Spoon Inspection", 29000),
  new Employee("Barbara Oak", "Xray", 21500),
  new Employee("Damien Parker", "Xray", 22000),
  new Employee("Nisha Patel", "Monkey Shit Removal", 21000),
  new Employee("Gustavo Sanchez", "Monkey Shit Removal", 20000),
};

CalculateAverageSalaryPerDepartment(employees);

Console.ReadKey();

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
  var employeesSalaries = new Dictionary<string, decimal>();

  foreach (Employee employee in employees)
  {
    decimal employeeSalary = 0;

    if (employee.Department == "Spoon Inspection")
    {
      employeeSalary += employee.MonthlySalary;
    }
    else if (employee.Department == "Xray")
    {
      xRayTotal += employee.MonthlySalary;
    }
    else if (employee.Department == "Monkey Shit Removal")
    {
      monkeyShitRemovalTotal += employee.MonthlySalary;
    }
  }
  decimal spoonAverage = spoonTotal / 2;
  decimal xRayAverage = xRayTotal / 2;
  decimal monkeyShitRemovalAverage = monkeyShitRemovalTotal / 2;


  return new Dictionary<string, decimal>()
  {
    ["Spoon Inspection"], spoonTotal / 2,
  }
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