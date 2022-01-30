using System;

class Program {
    static void Main(string[] args) {

        int x, y, min, max, soma, i;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x < y) {
            min = x;
            max = y;
        }
        else {
            min = y;
            max = x;
        }

        soma = 0;
        for (i = min + 1; i < max; i ++) {
            if (i % 2 != 0) {
                soma += i;
            }            
        }
        Console.WriteLine(soma);

        Console.ReadLine();
    }
}