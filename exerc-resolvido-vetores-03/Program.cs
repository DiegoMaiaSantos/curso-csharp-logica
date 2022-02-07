using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int n, i, contador;
        double soma, media, porcentagem; 
               
        n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        int[] idades = new int[n];
        double[] alturas = new double[n];

        // Leitura dos dados ==================================================
        for (i = 0; i < n; i++) {
            string[] dados = Console.ReadLine().Split(' ');
            nomes[i] = dados[0];
            idades[i] = int.Parse(dados[1]);
            alturas[i] = double.Parse(dados[2], CultureInfo.InvariantCulture);
        }

        // Calculo da altura média =============================================
        soma = 0.0;
        for (i = 0; i < n; i++) {
            soma += alturas[i];
        }
        // Colocar o calculo da média fora da estrutura "for" ==================
        media = soma / n;
        Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

        // Porcentagem de pessoas abaixo de 16 anos ============================
        contador = 0;
        for (i = 0; i < n; i++) {
            if (idades[i] < 16) {
                contador++;
            }            
        }
        porcentagem = (double) contador / n * 100.0;
        Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

        Console.ReadLine();
    }
}