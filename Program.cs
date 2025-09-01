using AlternateLesson.GenericMethods;

// var numbers = new SimpleList<int>();
// numbers.Add(10);
// numbers.Add(20);
// numbers.Add(30);
// numbers.Add(40);
// numbers.Add(50);

// numbers.RemoveAt(2);

// var words = new SimpleList<string>();
// words.Add("aaa");
// words.Add("bbb");
// words.Add("ccc");

// var dates = new SimpleList<DateTime>();
// dates.Add(new DateTime(2025, 1, 6));
// dates.Add(new DateTime(2025, 1, 3));

// Console.ReadKey();

// public class SimpleList<T>
// {
//   private T[] _items = new T[4];
//   private int _size = 0;

//   public void Add(T item)
//   {
//     if (_size >= _items.Length)
//     {
//       var newItems = new T[_items.Length * 2];

//       for (int i = 0; i < _items.Length; i++)
//       {
//         newItems[i] = _items[i];
//       }
//       _items = newItems;
//     }
//     _items[_size] = item;
//     ++_size;
//   }

//   public void RemoveAt(int index)
//   {
//     if (index < 0 || index > _size)
//     {
//       throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//     }

//     --_size;

//     for (int i = index; i < _size; ++i)
//     {
//       _items[i] = _items[i + 1];
//     }

//     _items[_size] = default;
//   }

//   public T GetAtIndex(int index)
//   {
//     if (index < 0 || index > _size)
//     {
//       throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//     }

//     return _items[index];
//   }
// }

// var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
// Tuple<int, int> minAndMax = GetMinAndMax(numbers);

// var twoStrings = new Tuple<string, string>("aaa", "bbb");
// var differentTypes = new Tuple<string, int>("aaa", 2);
// var threeItems = new Tuple<string, int, bool>("aaa", 2, false);
// System.Console.WriteLine($"Smallest number is {minAndMax.Item1}");
// System.Console.WriteLine($"Largest number is {minAndMax.Item2}");

// Console.ReadKey();

// Tuple<int,int> GetMinAndMax(List<int> numbers)
// {
//   if (!numbers.Any())
//   {
//     throw new InvalidOperationException($"Yo shit is empty buddy.");
//   }

//   int min = numbers.First();
//   int max = numbers.First();

//   foreach (int number in numbers)
//   {
//     if (number > max)
//     {
//       max = number;
//     }
//     if (number < min)
//     {
//       min = number;
//     }
//   }

//   return new Tuple<int,int>(min, max);
// }

// public class SimpleTuple<T1, T2>
// {
//   public T1 Item1 { get; }
//   public T2 Item2 { get; }
//   public SimpleTuple(T1 item1, T2 item2)
//   {
//     Item1 = item1;
//     Item2 = item2;
//   }
// }

// public class SimpleTuple<T1, T2, T3>
// {
//   public T1 Item1 { get; }
//   public T2 Item2 { get; }
//   public T3 Item3 { get; }
//   public SimpleTuple(T1 item1, T2 item2, T3 item3)
//   {
//     Item1 = item1;
//     Item2 = item2;
//     Item3 = item3;
//   }
// }

// var decimals = new List<decimal> { 1.1m, 0.5m, 22.5m, 12m };
// var ints = decimals.ConvertTo();
TupleSwapExercise.SwapTupleItems(new Tuple<int, int>(1, 2));

Console.ReadKey();

public static class TupleSwapExercise
{
  public static Tuple<T2, T1> SwapTupleItems<T1, T2>(Tuple<T1, T2> elements) => new Tuple<T2, T1>(elements.Item2, elements.Item1);
}