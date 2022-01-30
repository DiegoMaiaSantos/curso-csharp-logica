using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double c, f;
        char repetir;

        do {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Formula de celsius para fahrenheit:
            f = 9.0 * c / 5.0 + 32.0;
            Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("Deseja repetir (s/n)? ");
            repetir = char.Parse(Console.ReadLine());
        } while (repetir == 's');

        Console.ReadLine();
    }
}