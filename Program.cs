var countryToCurrencyMapping = new Dictionary<string, string>()
{
  ["USD"] = "USA",
  ["India"] = "INR",
  ["Spain"] = "EUR",
};

// countryToCurrencyMapping.Add("USA", "USD");
// countryToCurrencyMapping.Add("India", "INR");
// countryToCurrencyMapping.Add("Spain", "EUR");
// countryToCurrencyMapping.Add("Italy", "EUR");

countryToCurrencyMapping["Taco"] = "Bell";
System.Console.WriteLine(countryToCurrencyMapping["Taco"]);
countryToCurrencyMapping["Taco"] = "Cabana";
System.Console.WriteLine(countryToCurrencyMapping["Taco"]);


System.Console.WriteLine($"Currency in Spain is {countryToCurrencyMapping["Spain"]}");
// System.Console.WriteLine($"Currency in Spain is {countryToCurrencyMapping["Italy"]}");

foreach (var value in countryToCurrencyMapping)
{
  System.Console.WriteLine(value);
}

Console.ReadKey();