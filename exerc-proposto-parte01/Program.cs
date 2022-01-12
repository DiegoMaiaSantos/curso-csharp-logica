using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int tempoHoras, velocidadeMedia;
        double consumoVeiculo;

        tempoHoras = int.Parse(Console.ReadLine());
        velocidadeMedia = int.Parse(Console.ReadLine());  
        consumoVeiculo = velocidadeMedia * tempoHoras / 12.0;

        Console.WriteLine(consumoVeiculo.ToString("F3", CultureInfo.InvariantCulture));     
    }

}