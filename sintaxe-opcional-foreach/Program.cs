using System;

class Program {
    static void Main(string[] args) {

        int n;
        n = int.Parse(Console.ReadLine());
        string[] vet = new string[n];

        // Entrada de dados ===============================================
        for (int i = 0; i < n; i++) {
            vet[i] = Console.ReadLine();
        }

        // Saída de dados =================================================
        Console.WriteLine("Nomes lidos:");
        foreach (string x in vet) { // Muda de acordo com o tipo: string, int, double e etc.
            Console.WriteLine(x);
        }

        Console.ReadLine();
    }
}