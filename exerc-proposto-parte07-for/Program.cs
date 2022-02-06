// Exercício Beecrowd 1096:

using System;

class program {
    static void Main(string[] args) {

        int i, j;

        for (i = 1; i <= 9; i += 2) {
            for (j = 7; j >= 5; j --) {
                Console.WriteLine("I=" + i + " J=" + j + "\n");
            }
        }

        Console.ReadLine();
    }
}

// Exercício Beecrowd 1097:

using System;

class program {
    static void Main(string[] args) {

        int i, j; 

        j = 7;
        for (i = 1; i <= 9; i += 2) {
            Console.WriteLine("I=" + i + " J=" + j);
            Console.WriteLine("I=" + i + " J=" + (j - 1));
            Console.WriteLine("I=" + i + " J=" + (j - 2));
            j += 2;
        }       

        Console.ReadLine();
    }
}

// Exercício Beecrowd 1116:

using System;
using System.Globalization;

class program {
    static void Main(string[] args) {

        int x, y, z, contador;
        double resultado;

        x = int.Parse(Console.ReadLine());

        for (contador = 0; contador < x; contador ++) {

            string[] valores = Console.ReadLine().Split(' ');
            y = int.Parse(valores[0]);
            z = int.Parse(valores[1]);

            if (z == 0) {
                Console.WriteLine("divisao impossivel");
            }
            else {            
                resultado = (double)y / z;
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }       

        Console.ReadLine();
    }
}

// Exercício Beecrowd 1132:

using System;
using System.Globalization;

class program {
    static void Main(string[] args) {

        int x, y, menor, maior, soma, i;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        menor = x;
        maior = y;

        if (x > y) {
            menor = y;
            maior = x;
        }      

        soma = 0;
        for (i = menor; i <= maior; i++) {
            if (i % 13 != 0) {
                soma += i;
            }
        } 

        Console.WriteLine(soma);  

        Console.ReadLine();
    }
}

// Exercício Beecrowd 1133:

using System;

class program {
    static void Main(string[] args) {

        int x, y, i, aux;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y) {
            aux = x;
            x = y;
            y = aux;
        }

        for (i = x + 1; i < y; i ++) {
            if (i % 5 == 2 || i % 5 == 3) {
                Console.WriteLine(i);
            }
        }               

        Console.ReadLine();
    }
}