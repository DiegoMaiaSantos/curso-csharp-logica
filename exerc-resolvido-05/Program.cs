using System;
using System.Globalization;

namespace aula_estrutura_condicionais {
    class Program {
        static void Main(string[] args) {

        double nota1, nota2, soma;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        soma = nota1 + nota2;

        if (soma >= 60.0) {
            Console.WriteLine("Média final = " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aprovado!");
        }
        else {
            Console.WriteLine("Média final = " + soma.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reprovado!");
        }
        }
    }
}