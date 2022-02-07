using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int n, i;
        double soma, media;
        double[] vetores;
        n = int.Parse(Console.ReadLine());
        vetores = new double[n];

        string[] valores = Console.ReadLine().Split();
        for (i = 0; i < n; i ++) {
            vetores[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);            
        }

        for (i = 0; i < n; i ++) {
            Console.Write(vetores[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();

        soma = 0.0;
        for (i = 0; i < n; i ++) {
            soma = soma + vetores[i];
        }
        media = soma / n;

        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
}