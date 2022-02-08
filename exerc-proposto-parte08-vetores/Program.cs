// Exercício 01 ======================================================

using System;
using System.Globalization;

class Programa {
    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];

        // Entrada de dados para os valores solicitados ==========================
        string[] valores = Console.ReadLine().Split(' ');
        
        for (int i = 0; i < n; i++) {
            vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
        }

        double maior = vet[0];
        int posicaoMaior = 0;

        for (int i = 1; i < n; i++) {
            if (vet[i] > maior) {
                maior = vet[i];
                posicaoMaior = i;
            }
        }

        Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(posicaoMaior);

        Console.ReadLine();
    }
}

// Exercício 02 ======================================================

using System;
using System.Globalization;

class Programa {
    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());

        int[] vet = new int[n];

        string[] valores = Console.ReadLine().Split(' ');

        // Entrada de dados ============================================
        for (int i = 0; i < n; i++) {
            vet[i] = int.Parse(valores[i]);
        }

        // Saída dos números pares =====================================
        for (int i = 0; i < n; i++) {
            if (vet[i] % 2 == 0) {
                Console.Write(vet[i] + " ");
            }
        } 
        Console.WriteLine();

        // Quantidade dos números pares ================================
        int quantidadePares = 0;
        for (int i = 0; i < n; i++) {
            if (vet[i] % 2 == 0) {
                quantidadePares += 1;
            }
        } 

        Console.WriteLine(quantidadePares);     

        Console.ReadLine();
    }
}