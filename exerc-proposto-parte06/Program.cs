//Exercício Beecrowd 1114:

using System;

class Program {
    static void Main(string[] args) {

        int senha;

        senha = int.Parse(Console.ReadLine());

        while (senha != 2002) {
            Console.WriteLine("Senha Invalida");
            senha = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Acesso Permitido");

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1115:

using System;

class Program {
    static void Main(string[] args) {

        int x, y;

        string[] valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);

        while (x != 0 && y != 0) {
            if (x > 0 && y > 0) {
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("terceiro");
            }
            else {
                Console.WriteLine("quarto");
            }
            valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
        }

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1117:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota1 < 0.0 || nota1 > 10.0) {
            Console.WriteLine("nota invalida");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }  

        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota2 < 0.0 || nota2 > 10.0) {
            Console.WriteLine("nota invalida");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        } 

        media = (nota1 + nota2) / 2.0;
        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));                     

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1134:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int numero, alcool, gasolina, diesel;

        numero = int.Parse(Console.ReadLine());

        alcool = 0;
        gasolina = 0;
        diesel = 0;
        while (numero != 4) {
            if (numero == 1) {
                alcool += 1;                
            }
            if (numero == 2) {
                gasolina += 1;
            }
            if (numero == 3) {
                diesel += 1;
            }
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1154:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int idade, contador;
        double media, soma;

        idade = int.Parse(Console.ReadLine());

        contador = 0;
        soma = 0.0;
        while (idade >= 0) {
            soma += idade;
            contador += 1;
            idade = int.Parse(Console.ReadLine());
        }

        media = soma / contador;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));    

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1159:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int x, soma;

        x = int.Parse(Console.ReadLine());

        while (x != 0) {
            // se for impar, some mais 1
            // par é quando (x % 2 = 0) e impar (x % 2 != 0) IMPORTANTE!!!
            if (x % 2 != 0) {
                x += 1;
            }
            // expressão somplificada: 5 * x + 20
            soma = x + x + 2 + x + 4 + x + 6 + x + 8;
            Console.WriteLine(soma); 

            x = int.Parse(Console.ReadLine());
        }

        Console.ReadLine();
    }
}