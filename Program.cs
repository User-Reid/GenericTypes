var numbers = new[] { 1, 4, 7, 19, 2 };
// Func<int, bool> predicate1 = IsLargerThan10;
System.Console.WriteLine($"Are there numbers greater than 10? {IsAny(numbers, n => n > 10)}");
// Func<int, bool> predicate2 = IsEven;
System.Console.WriteLine($"Are there any even numbers? {IsAny(numbers, n => n % 2 == 0)}");
Console.ReadKey();

Func<int, DateTime, string, decimal> someFunc;
Action<string, string, bool> someAction;

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
  foreach (int number in numbers)
  {
    if (predicate(number))
    {
      return true;
    }
  }
  return false;
}