//Estrutura repetitiva "for":

using System;

class Program {
    static void Main(string[] args) {

        int n, x, i, soma;

        n = int.Parse(Console.ReadLine());
        
        soma = 0;
        // início - condição - incremento:   
        for (i = 1; i <= n; i ++) {
            x = int.Parse(Console.ReadLine());
            soma += x;
        }

        Console.WriteLine(soma);
        Console.ReadLine();
    }
}

// Contagem decrescente de 0 até 10:

using System;

class Program {
    static void Main(string[] args) {

        int i;

        for (i = 0; i < 11; i ++) {
            Console.WriteLine("Valor de i: " + i);
        }

        Console.ReadLine();
    }
}

//Contagem regressiva de 10 até 0:

using System;

class Program {
    static void Main(string[] args) {

        int i;

        for (i = 10; i >= 0; i --) {
            Console.WriteLine("Valor de i: " + i);
        }

        Console.ReadLine();
    }
}