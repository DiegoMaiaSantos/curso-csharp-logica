// Processamento de dados C#

// Exemplo 01:

using System.Globalization; //P usar a função que muda virgula p ponto.

int x, y;  // int é a representação de inteiro.
x = 5;
y = 2 * x;

Console.WriteLine(x);
Console.WriteLine(y);

Console.WriteLine();

//Exemplo 02:

int x2;
double y2;

x2 = 5;
y2 = 2 * x;

Console.WriteLine(x2);
Console.WriteLine(y2);

Console.WriteLine();

//Exemplo 03:

double b, B, h, area;

b = 6.0;
B = 8.0;
h = 5.0;

area = (b + B) / 2.0 * h;

Console.WriteLine(area);

Console.WriteLine();

//Exemplo 04:

int a, b2;
double resultado;

a = 5;
b2 = 2;

resultado = (double)a / b2;

Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));

Console.WriteLine();

//Exemplo 05:

double a2;
int b3;

a2 = 5.0;
b3 = (int) a2;

Console.WriteLine(b3);

Console.ReadLine();