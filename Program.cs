// var numbers = new[] { 1, 4, 7, 19, 2 };
// // Func<int, bool> predicate1 = IsLargerThan10;
// System.Console.WriteLine($"Are there numbers greater than 10? {IsAny(numbers, IsLargerThan10)}");
// // Func<int, bool> predicate2 = IsEven;
// System.Console.WriteLine($"Are there any even numbers? {IsAny(numbers, IsEven)}");
// Console.ReadKey();

// Func<int, DateTime, string, decimal> someFunc;
// Action<string, string, bool> someAction;

// bool IsLargerThan10(int number)
// {
//   return number > 10;
// }

// bool IsEven(int number)
// {
//   return number % 2 == 0;
// }

// bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
// {
//   foreach (int number in numbers)
//   {
//     if (predicate(number))
//     {
//       return true;
//     }
//   }
//   return false;
// }

public class Exercise
    {
        public void TestMethod()
        {
            Func<int, bool, double> someMethod1 = Method1;
            Func<DateTime> someMethod2 = Method2;
            Action<string, string> someMethod3 = Method3;
        }
        
        public double Method1(int a, bool b) => 0;
        public DateTime Method2() => default(DateTime);
        public void Method3(string a, string b) {}
    }