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