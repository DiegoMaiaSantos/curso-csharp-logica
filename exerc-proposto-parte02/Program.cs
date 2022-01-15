// Exercício 1011 Beecrowd

using System; 
using System.Globalization;
class URI {
    static void Main(string[] args) { 

        double r, pi, volume;

        r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        pi = 3.14159;
        
        volume = (4.0 / 3.0) * pi * Math.Pow(r, 3.0);

        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }

}

// Exercício 1012 Beecrowd

using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo, pi;  

        string[] valores = Console.ReadLine().Split(' '); 
        a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        c = double.Parse(valores[2], CultureInfo.InvariantCulture);
        pi = 3.14159;

        triangulo = a * c / 2.0;
        circulo = pi * Math.Pow(c, 2.0); 
        trapezio = (a + b) * c / 2.0;             
        quadrado = Math.Pow(b, 2.0);
        retangulo = a * b;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }

}

// Exercício 1013 Beecrowd

using System; 

class URI {

    static void Main(string[] args) { 

        int a, b, c, maiorAB, maior;

        string[] valores = Console.ReadLine().Split(' ');
        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;

        maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine(maior + " eh o maior");
    }

}

// Exercício 1015 Beecrowd

using System;
using System.Globalization; 

class URI {

    static void Main(string[] args) { 

        double x1, x2, y1, y2, distancia;

        string[] valores = Console.ReadLine().Split(' ');
        x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }

}