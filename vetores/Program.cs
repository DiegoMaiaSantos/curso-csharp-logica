// Novo conteúdo: Vetores.

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int n, i;
        double[] vet; // Para definir o tipo de vetor.

        n = int.Parse(Console.ReadLine());
        vet = new double[n]; // Para instanciar o vetor.

        // Esse for vai receber os valores e armazenar.
        for (i = 0; i < n; i ++) {
            vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        
        // Esse for vai mostrar na tela os valores.
        for (i = 0; i < n; i ++) {
            Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
        }

        Console.ReadLine();
    }
}