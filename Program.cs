var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };
string userInput;

System.Console.WriteLine(@"Select filter:
Even
Odd");

userInput = Console.ReadLine();

List<int> result = new NumbersFilter().FilterBy(userInput, numbers);

Print(result);

Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
  System.Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter
{
  public List<int> FilterBy(string filteringType, List<int> numbers)
  {

    switch (filteringType)
    {
      case "Even": return Select(numbers, number => number % 2 == 0);
      case "Odd": return Select(numbers, number => number % 2 != 0);
      case "Positive": return Select(numbers, number => number > 0);
      default:
        {
          throw new Exception($"Yo shit chalked cuh");
        }
    }
  }

private List<int> Select(List<int> numbers, Func<int, bool> predicate)
  {
    var result = new List<int>();
    foreach (int number in numbers)
    {
      if (predicate(number))
      {
        result.Add(number);
      }
    }
    return result;
  }
}


