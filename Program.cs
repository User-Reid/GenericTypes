// var dataDownloader = new SlowDataDownloader();

// System.Console.WriteLine(dataDownloader.DownloadData("id1"));
// System.Console.WriteLine(dataDownloader.DownloadData("id2"));
// System.Console.WriteLine(dataDownloader.DownloadData("id3"));
// System.Console.WriteLine(dataDownloader.DownloadData("id1"));
// System.Console.WriteLine(dataDownloader.DownloadData("id3"));
// System.Console.WriteLine(dataDownloader.DownloadData("id1"));
// System.Console.WriteLine(dataDownloader.DownloadData("id2"));

// Console.ReadKey();

// public interface IDataDownloader
// {
//   string DownloadData(string resouceId);
// }

// public class SlowDataDownloader : IDataDownloader
// {
//   public string DownloadData(string resouceId)
//   {
//     // let's imagine this method downloads real data,
//     // and it does it slowly
//     Thread.Sleep(1000);
//     return $"Some data for {resouceId}";
//   }
// }
var taco = new Calculations();
taco.FindMinAndMax(new List<int>()
{
  78, 84, 43, 27, 36, 92, 12, 543
});

Console.ReadKey();

public class Calculations
{
  public List<int> FindMinAndMax(IEnumerable<int> numbers)
  {
    var min = numbers.First();
    var max = numbers.First();
    foreach (int number in numbers)
    {
      if (number > max)
      {
        max = number;
      }
      if (number < min)
      {
        min = number;
      }
    }
    List<int> result = new List<int>() { min, max };
    foreach (int number in result)
    {
      System.Console.WriteLine(number);
    }
    return result;
  }
}