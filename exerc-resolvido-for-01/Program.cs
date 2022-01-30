using System;

class Program {
    static void Main(string[] args) {

        int n, i, resultado;

        n = int.Parse(Console.ReadLine());
        
        for (i = 1; i <= 10; i ++) {
            resultado = i * n;
            Console.WriteLine(i + " x " + n + " = " + resultado);
        }

        Console.ReadLine();
    }
}