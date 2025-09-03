
ProcessString processString1 = TrimTo5Letters;
ProcessString processString2 = ToUpper;
System.Console.WriteLine(processString1("FUUUUUCKKKCKCKCKC"));
System.Console.WriteLine(processString2("HOWWDYyyyyyyyyyyyyy"));

Print print1 = text => System.Console.WriteLine(text.ToUpper());
Print print2 = text => System.Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print4 = text => System.Console.WriteLine(text.Substring(0, 3));
multicast += print4;
multicast("Crocodile");


Console.ReadKey();


string TrimTo5Letters(string input)
{
  return input.Substring(0, 5);
}

string ToUpper(string input)
{
  return input.ToUpper();
}

delegate string ProcessString(string input);
delegate void Print(string input);