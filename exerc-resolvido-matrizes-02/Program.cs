using System;

class Program {
    static void Main(string[] args) {

        int m, n;
        int[,] a;

        string[] s = Console.ReadLine().Split(' ');
        m = int.Parse(s[0]);
        n = int.Parse(s[1]);
        a = new int[m, n];
        
        for (int i = 0; i < m; i++) {
            s = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++) {
                a[i, j] = int.Parse(s[j]);
            }
        }

        int[] vet = new int[m];

        for (int i = 0; i < m; i++) {
            int soma = 0;
            for (int j = 0; j < n; j++) {
                soma += a[i, j];
            }
            vet[i] = soma;
        }

        for (int i = 0; i < m; i++) {
            Console.WriteLine(vet[i]);
        }

        Console.ReadLine();
    }
}