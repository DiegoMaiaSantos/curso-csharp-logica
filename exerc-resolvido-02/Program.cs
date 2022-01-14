using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

          double baseAltura, alturaRetangulo, area, perimetro, diagonal;

          baseAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

          area = baseAltura * alturaRetangulo;
          perimetro = 2 * (baseAltura + alturaRetangulo);
          diagonal = Math.Sqrt(Math.Pow(baseAltura, 2.0) + Math.Pow(alturaRetangulo, 2.0));

          Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
          Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
          Console.WriteLine("Diagnoal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

          Console.ReadLine();  
        }
    }
}