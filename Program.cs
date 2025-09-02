var john = new Person(){  Name = "John",  YearOfBirth = 1980};
var anna = new Person() { Name = "Anna", YearOfBirth = 1915 };

PrintInOrder(10, 5);
PrintInOrder("aaa", "bb");
PrintInOrder(anna, john);

Console.ReadKey();

void PrintInOrder<T>(T first, T second) where T : IComparable<T>
{
  if (first.CompareTo(second) > 0)
  {
    System.Console.WriteLine($"{second} {first}");
  }
  else
  {
    System.Console.WriteLine($"{first} {second}");
  }
}

IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons) where TPerson : Person
{
  var result = new List<TPerson>();

  foreach (var person in persons)
  {
    if (person.YearOfBirth > 1900 && person.YearOfBirth < DateTime.Now.Year)
    {
      result.Add(person);
    }
  }
  return result;
}

public class Person : IComparable<Person>
{
  public string Name { get; init; }
  public int YearOfBirth { get; init; }

  public override string ToString() => $"{Name} was born in {YearOfBirth}"; 

  public int CompareTo(Person other)
  {
    if (YearOfBirth < other.YearOfBirth)
    {
      return 1;
    }
    else if (YearOfBirth > other.YearOfBirth)
    {
      return -1;
    }
    return 0;
  }
}

public class Employee : Person
{
  public void GoToWork() => System.Console.WriteLine("Going to work! Fuck my life!😀");
}