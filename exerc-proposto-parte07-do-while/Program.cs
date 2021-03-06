//Exercício Beecrowd 1067:

using System; 

class URI {

    static void Main(string[] args) { 

        int x, i;

        x = int.Parse(Console.ReadLine());

        for (i = 1; i <= x; i++) {
            if (i % 2 != 0) {
                Console.WriteLine(i);
            }            
        } 

        Console.ReadLine();      
    }
}

//Exercício Beecrowd 1072:

using System; 

class URI {

    static void Main(string[] args) { 

        int n, x, i, cont_In, cont_Out;

        n = int.Parse(Console.ReadLine());

        cont_In = 0;
        cont_Out = 0;
        
        for (i = 0; i < n; i ++) {
            x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20) {
                cont_In += 1;
            }
            else {
                cont_Out += 1;
            }
        }  

        Console.WriteLine(cont_In + " in");
        Console.WriteLine(cont_Out + " out");      

        Console.ReadLine();      
    }
}

//Exercício Beecrowd 1073:

using System; 

class URI {

    static void Main(string[] args) { 

        int n, i, quadrado;

        n = int.Parse(Console.ReadLine());

        quadrado = 0;
        for (i = 1; i <= n; i ++) {
            if (i % 2 == 0) {
                quadrado = i * i;
                Console.WriteLine(i + "^2 = " + quadrado);
            }
        }             

        Console.ReadLine();      
    }
}

//Exercício Beecrowd 1074:

using System; 

class URI {

    static void Main(string[] args) { 

        int n, i, valores;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i ++) {

            valores = int.Parse(Console.ReadLine());
            
            if (valores == 0) {
                Console.WriteLine("NULL");
            }
            else if (valores > 0) {
                if (valores % 2 == 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else {
                    Console.WriteLine("ODD POSITIVE");                
                }
            }
            else {
                    if (valores % 2 == 0) {                
                    Console.WriteLine("EVEN NEGATIVE");
                 }
                else {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }                   

        Console.ReadLine();      
    }
}

//Exercício Beecrowd 1075:

using System;

class Program {
    static void Main(string[] args) {

        int x, i;

        x = int.Parse(Console.ReadLine());

        for (i = 0; i < 10000; i ++) {
            if (i % x == 2) {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1079:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int n, i;
        double nota1, nota2, nota3, media;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i ++) {

            string[] valores = Console.ReadLine().Split(' ');
            nota1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));           
        }  

        Console.ReadLine();
    }
}

// Exercício Beecrowd 1080:

using System;

class Program {
    static void Main(string[] args) {

        int maior, posicao, i, x;

        maior = int.Parse(Console.ReadLine());
        posicao = 1;
        
        for (i = 2; i <= 100; i ++) {
            x = int.Parse(Console.ReadLine());
            if (x > maior) {
                maior = x;
                posicao = i;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);

        Console.ReadLine();
    }
}

//Exercícios Beecrowd 1094:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        char tipo;
        int valorEntrada, contador, totalAnimais, coelhos, ratos, sapos, quantidade;
        double percentualCoelhos, percentualRatos, percentualSapos;

        valorEntrada = int.Parse(Console.ReadLine());        
        
        coelhos = 0;
        ratos = 0;
        sapos = 0;

        for (contador = 0; contador < valorEntrada; contador ++) {

            string[] valores = Console.ReadLine().Split(' ');
            quantidade = int.Parse(valores[0]);
            tipo = char.Parse(valores[1]);          

            if (tipo == 'C') {
                coelhos += quantidade;
            }
            else if (tipo == 'R') {
                ratos += quantidade;
            }
            else {
                sapos += quantidade;
            }
        }

        totalAnimais = coelhos + ratos + sapos;
        percentualCoelhos = (double)coelhos / totalAnimais * 100.0;
        percentualRatos = (double)ratos / totalAnimais * 100.0;
        percentualSapos = (double)sapos / totalAnimais * 100.0;

        Console.WriteLine("Total: " + totalAnimais + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);
        Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");

        Console.ReadLine();
    }
}