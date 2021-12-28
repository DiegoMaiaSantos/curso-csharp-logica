//Exercício de fixação

//Fazer um programa para executar a seguinte 
//unteração com o usuário, lendo os valores 
//destacados em vermelho, e depois mostrar os dados na tela

using System.Globalization

string nome = string.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');