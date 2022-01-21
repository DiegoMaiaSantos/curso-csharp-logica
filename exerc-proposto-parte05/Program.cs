//Exercício Beecrowd 1037:

using System;
using System.Globalization;

class Program {
    static void Main(string[] arfs) {

        double valor;

        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (valor < 0.0 || valor > 100.0) {
            Console.WriteLine("Fora de intervalo");
        }  
        else if (valor <= 25.0) {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor <= 50.0) {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (valor <= 75.0) {
            Console.WriteLine("Intervalo (50,75]");
        }
        else {
            Console.WriteLine("Intervalo (75,100]");
        }

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1040:

using System;
using System.Globalization;

class Program {
    static void Main(string[] arfs) {

        float n1, n2, n3, n4, media, notaExame, mediaFinal;

        string[] notas = Console.ReadLine().Split(' ');
        n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
        n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
        n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
        n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

        media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

        if (media == 4.85f) {
            media = 4.8f;
        }

        if (media >= 7.0) {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0) {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno reprovado.");
        }
        else {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");
            notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mediaFinal = (media + notaExame) / 2;
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
            if (mediaFinal >= 5.0) {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Aluno reprovado.");
                
            }

        }

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1041:

using System;
using System.Globalization;

class Program {
    static void Main(string[] arfs) {

        double x, y; 

        string[] valores = Console.ReadLine().Split(' ');
        x = double.Parse(valores[0], CultureInfo.InvariantCulture);
        y = double.Parse(valores[1], CultureInfo.InvariantCulture);

        if (x == 0.0 && y == 0.0) {
            Console.WriteLine("Origem");
        }       
        else if (x == 0.0) {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0) {
            Console.WriteLine("Eixo X");
        }  
        else if (x > 0.0 && y > 0.0) {
            Console.WriteLine("Q1");
        }   
        else if (x < 0.0 && y > 0.0) {
            Console.WriteLine("Q2");
        }  
        else if (x < 0.0 && y < 0.0) {
            Console.WriteLine("Q3");
        }    
        else {
            Console.WriteLine("Q4");
        }
       
        Console.ReadLine();
    }
}

//Exercício Beecrowd 1045:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double n1, n2, n3, a, b, c;

        string[] valores = Console.ReadLine().Split(' ');
        n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
        n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        if (n1 > n2 && n1 > n3) {
            a = n1;
            if (n2 > n3) {
                b = n2;
                c = n3;
            }
            else {
                b = n3;
                c = n2;
            }
        }
        else if (n2 > n3) {
            a = n2;
            if (n1 > n3) {
                b = n1;
                c = n3;
            }
            else {
                b = n3;
                c = n1;
            }
        }
        else {
            a = n3;
            if (n1 > n2) {
                b = n1;
                c = n2;
            }
            else {
                b = n2;
                c = n1;
            }
        }

        if (a >= b + c) {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else {
            if (Math.Pow(a, 2.0) == Math.Pow(b, 2.0) + Math.Pow(c, 2.0)) {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2.0) > Math.Pow(b, 2.0) + Math.Pow(c, 2.0)) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
        }

        if (a == b && b == c) {
            Console.WriteLine("TRIANGULO EQUILATERO");            
        }
        else if (a == b || a == c || b == c) {
            Console.WriteLine("TRIANGULO ISOSCELES");           
        }

        Console.ReadLine();
    }
}