namespace AlternateLesson.GenericMethods
{
  public static class ListExtensions
  {
    public static void AddToFront<T>(this List<T> list, T item)
    {
      list.Insert(0, item);
    }

    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
    {
      var result = new List<TSource>();

      foreach (decimal number in decimals)
      {
        result.Add((TTarget)number);
      }
      return result;
    }
  }
}