using System;

class Program {
    static void Main(string[] args) {

        int n, i;
        int[] vetores;

        n = int.Parse(Console.ReadLine());
        vetores = new int[n];

        string[] valores = Console.ReadLine().Split(' ');
        for (i = 0; i < n; i ++) {
            vetores[i] = int.Parse(valores[i]);
        }

        for (i = 0; i < n; i ++) {
            if (vetores[i] < 0) {
                Console.WriteLine(vetores[i]);
            }
        }

        Console.ReadLine();
    }
}