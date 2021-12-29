//Exercício de fixação

//Fazer um programa para executar a seguinte 
//unteração com o usuário, lendo os valores 
//destacados em vermelho, e depois mostrar os dados na tela

using System.Globalization;

string nome = Console.ReadLine();
int n1 = int.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string nome1 = vet[0];
int n3 = int.Parse(vet[1]);
double n4 = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Digite o seu nome: ");
Console.WriteLine(nome);
Console.WriteLine("Quantos quartos tem na sua casa? ");
Console.WriteLine(n1);
Console.WriteLine("Preço do produto: ");
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Primeiro nome, idade e altura: ");
Console.WriteLine(nome1);
Console.WriteLine(n3);
Console.WriteLine(n4.ToString("F2", CultureInfo.InvariantCulture));