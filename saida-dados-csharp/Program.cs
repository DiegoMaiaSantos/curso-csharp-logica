using System.Globalization;

double x = 10.35784;

Console.WriteLine(x);
Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F4"));

Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));


Console.Read();