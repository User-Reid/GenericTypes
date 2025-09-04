var dataDownloader = new SlowDataDownloader();

System.Console.WriteLine(dataDownloader.DownloadData("id1"));
System.Console.WriteLine(dataDownloader.DownloadData("id2"));
System.Console.WriteLine(dataDownloader.DownloadData("id3"));
System.Console.WriteLine(dataDownloader.DownloadData("id1"));
System.Console.WriteLine(dataDownloader.DownloadData("id3"));
System.Console.WriteLine(dataDownloader.DownloadData("id1"));
System.Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
  string DownloadData(string resouceId);
}