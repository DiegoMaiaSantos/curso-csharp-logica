using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double idade, soma, media;
        int contador;

        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  

        soma = 0.0;
        contador = 0;
        while (idade >= 0) {
            soma += idade;
            contador += 1;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
        }
        if (contador == 0) {
            Console.WriteLine("Impossivel calcular");
        }
        else {
            media = soma / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        } 

        Console.ReadLine();        
    }
}