// var employees = new List<Employee> {
//   new Employee("Jake Smith", "Spoon Inspection", 25000),
//   new Employee("Anna Blake", "Spoon Inspection", 29000),
//   new Employee("Barbara Oak", "Xray", 21500),
//   new Employee("Damien Parker", "Xray", 22000),
//   new Employee("Nisha Patel", "Monkey Shit Removal", 21000),
//   new Employee("Gustavo Sanchez", "Monkey Shit Removal", 20000),
// };

// var taco = CalculateAverageSalaryPerDepartment(employees);

// Console.ReadKey();

// Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
// {
//   var employeesPerDepartments = new Dictionary<string, List<Employee>>();

//   foreach (var employee in employees)
//   {
//     if (!employeesPerDepartments.ContainsKey(employee.Department))
//     {
//       employeesPerDepartments[employee.Department] = new List<Employee>();
//     }
//     employeesPerDepartments[employee.Department].Add(employee);
//   }

//   var result = new Dictionary<string, decimal>();

//   foreach (var employeesPerDepartment in employeesPerDepartments)
//   {
//     decimal sumOfSalaries = 0;

//     foreach (var employee in employeesPerDepartment.Value)
//     {
//       sumOfSalaries += employee.MonthlySalary;
//     }

//     var average = sumOfSalaries / employeesPerDepartment.Value.Count();

//     result[employeesPerDepartment.Key] = average;
//   }
//   return result;
// }

// public class Employee
// {
//   public string Name { get; }
//   public string Department { get; }
//   public decimal MonthlySalary { get; }
//   public Employee(string name, string department, decimal monthlySalary)
//   {
//     Name = name;
//     Department = department;
//     MonthlySalary = monthlySalary;
//   }
// }

var taco = Exercise.FindMaxWeights(new List<Pet>()
{
  new Pet(PetType.Dog, 10),
  new Pet(PetType.Cat, 5),
  new Pet(PetType.Fish, 0.9),
  new Pet(PetType.Dog, 45),
  new Pet(PetType.Cat, 2),
  new Pet(PetType.Fish, 0.02)
});

Console.ReadKey();

public static class Exercise
    {
  public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
  {
    var maxWeightPets = new Dictionary<PetType, double>();
    
    foreach (var pet in pets)
    {
      if (!maxWeightPets.ContainsKey(pet.PetType) || pet.Weight > maxWeightPets[pet.PetType])
      {
        maxWeightPets[pet.PetType] = pet.Weight;
      }
    }
    return maxWeightPets;
  }
}
    
    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }
    
        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;    
        }
        
        public override string ToString() => $"{PetType}, {Weight} kilos";
    }
    
    public enum PetType { Dog, Cat, Fish }