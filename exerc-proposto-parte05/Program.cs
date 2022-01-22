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

//Exercício Beecrowd 1047:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int horaInicio, minutoInicio, horaFinal, minutoFinal, instanteInicial, instanteFinal, duracao, duracaoHoras, duracaoMinutos;

        string[] valores = Console.ReadLine().Split(' ');
        horaInicio = int.Parse(valores[0]);               
        minutoInicio = int.Parse(valores[1]);               
        horaFinal = int.Parse(valores[2]);               
        minutoFinal = int.Parse(valores[3]); 

        instanteInicial = horaInicio * 60 + minutoInicio;
        instanteFinal = horaFinal * 60 + minutoFinal;

        if (instanteInicial < instanteFinal) {
            duracao = instanteFinal - instanteInicial;
        }
        else {
            duracao = (24 * 60 - instanteInicial) + instanteFinal;
        }

        duracaoHoras = duracao / 60;
        duracaoMinutos = duracao % 60;

        Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1047:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        string palavra1, palavra2, palavra3, resultado;

        palavra1 = Console.ReadLine();        
        palavra2 = Console.ReadLine();        
        palavra3 = Console.ReadLine();

        if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro" ) {
            resultado = "aguia";
        }   
        else if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro" ) {
            resultado = "pomba";
        }      
        else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro" ) {
            resultado = "homem";
        }      
        else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro" ) {
            resultado = "vaca";
        }      
        else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago" ) {
            resultado = "pulga";
        }      
        else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro" ) {
            resultado = "lagarta";
        }      
        else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago" ) {
            resultado = "sanguessuga";
        }
        else {
            resultado = "minhoca";            
        }      

        Console.WriteLine(resultado);

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1042:

using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        int x, y, z, maior, meio, menor;

        string[] valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);
        z = int.Parse(valores[2]);

        if (x < y && x < z) {
            menor = x;
            if (y < z) {
                meio = y;
                maior = z;
            }
            else {
                meio = z;
                maior = y;
            }
        }
        else if (y < z) {
            menor = y;
            if (x < z) {
                meio = x;
                maior = z;
            }
            else {
                meio = z;
                maior = x;
            }
        }
        else {
            menor = z;
            if (x < y) {
                meio = x;
                maior = y;
            }
            else {
                meio = y;
                maior = x;
            }
        }
        
        Console.WriteLine(menor);
        Console.WriteLine(meio);
        Console.WriteLine(maior);
        Console.WriteLine();
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1043:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double a, b, c, perimetro, area;

        string[] valores = Console.ReadLine().Split(' ');
        a = double.Parse(valores[0], CultureInfo.InvariantCulture);            
        b = double.Parse(valores[1], CultureInfo.InvariantCulture);            
        c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        if (a < b + c && b < a + c && c < a + b)    {
            perimetro = a + b + c;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
        }   
        else {
            area = ((a + b) * c) / 2.0;
            Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
        }      

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1050:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int ddd;

        ddd = int.Parse(Console.ReadLine());

        if (ddd == 61) {
            Console.WriteLine("Brasilia");
        }     
        else if (ddd == 71) {
            Console.WriteLine("Salvador");            
        }       
        else if (ddd == 11) {
            Console.WriteLine("Sao Paulo");            
        }       
        else if (ddd == 21) {
            Console.WriteLine("Rio de Janeiro");            
        }       
        else if (ddd == 32) {
            Console.WriteLine("Juiz de Fora");            
        }       
        else if (ddd == 19) {
            Console.WriteLine("Campinas");            
        }       
        else if (ddd == 27) {
            Console.WriteLine("Vitoria");            
        }   
        else if (ddd == 31) {
            Console.WriteLine("Belo Horizonte");          
        }   
        else {
            Console.WriteLine("DDD nao cadastrado");
        } 

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1052:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int number;

        number = int.Parse(Console.ReadLine());

        if (number == 1) {
            Console.WriteLine("January");
        }     
        else if (number == 2) {
            Console.WriteLine("February");
        }   
        else if (number == 3) {
            Console.WriteLine("March");
        }   
        else if (number == 4) {
            Console.WriteLine("April");
        }   
        else if (number == 5) {
            Console.WriteLine("May");
        }   
        else if (number == 6) {
            Console.WriteLine("June");
        }   
        else if (number == 7) {
            Console.WriteLine("July");
        }   
        else if (number == 8) {
            Console.WriteLine("August");
        }   
        else if (number == 9) {
            Console.WriteLine("September");
        }   
        else if (number == 10) {
            Console.WriteLine("October");
        }   
        else if (number == 11) {
            Console.WriteLine("November");
        } 
        else if (number == 12) {
            Console.WriteLine("December");
        } 
        else {
            Console.WriteLine("Invalid value");
        }

        Console.ReadLine();
    }
}

//Exercício Beecrowd 1060:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double n1, n2, n3, n4, n5, n6, contador;

        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        contador = 0;
        if (n1 > 0.0) {
            contador = contador + 1;     
        }   
        if (n2 > 0.0) {
            contador = contador + 1;
        }
        if (n3 > 0.0) {
            contador = contador + 1;
        }
        if (n4 > 0.0) {
            contador = contador + 1;
        }
        if (n5 > 0.0) {
            contador = contador + 1;
        }
        if (n6 > 0.0) {
            contador = contador + 1;
        }

        Console.WriteLine(contador + " valores positivos");
        
        Console.ReadLine();
    }
}

//Exercício Beecrowd 1064:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double n1, n2, n3, n4, n5, n6, contador, soma, media;

        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
        n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
        n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
        n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
        n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

        contador = 0;
        soma = 0.0;
        if (n1 > 0.0) {
            contador = contador + 1;
            soma = soma + n1;
        }      
        if (n2 > 0.0) {
            contador = contador + 1;
            soma = soma + n2;
        }      
        if (n3 > 0.0) {
            contador = contador + 1;
            soma = soma + n3;
        }      
        if (n4 > 0.0) {
            contador = contador + 1;
            soma = soma + n4;
        }      
        if (n5 > 0.0) {
            contador = contador + 1;
            soma = soma + n5;
        }      
        if (n6 > 0.0) {
            contador = contador + 1;
            soma = soma + n6;
        } 

        media = soma / contador;

        Console.WriteLine(contador + " valores positivos");
        Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);    
        
        Console.ReadLine();
    }
}

//Exercício Beecrowd 1065:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int n1, n2, n3, n4, n5, contador;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());
        n5 = int.Parse(Console.ReadLine());

        contador = 0;
        if (n1 % 2 == 0) {
            contador = contador + 1;
        }          
        if (n2 % 2 == 0) {
            contador = contador + 1;
        }          
        if (n3 % 2 == 0) {
            contador = contador + 1;
        }          
        if (n4 % 2 == 0) {
            contador = contador + 1;
        }          
        if (n5 % 2 == 0) {
            contador = contador + 1;
        }   

        Console.WriteLine(contador + " valores pares");       
        
        Console.ReadLine();
    }
}

//Exercício Beecrowd 1066:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int n1, n2, n3, n4, n5, pares, impares, positivos, negativos;

        n1 = int.Parse(Console.ReadLine());       
        n2 = int.Parse(Console.ReadLine());       
        n3 = int.Parse(Console.ReadLine());       
        n4 = int.Parse(Console.ReadLine());       
        n5 = int.Parse(Console.ReadLine());  

        pares = 0;
        impares = 0;
        positivos = 0;
        negativos = 0;

        if (n1 % 2 == 0) {
            pares++;
        }
        else {
            impares++;
        }
        if (n1 > 0) {
            positivos++;
        }
        else if (n1 < 0) {
            negativos++;
        }

        if (n2 % 2 == 0) {
            pares++;
        }
        else {
            impares++;
        }
        if (n2 > 0) {
            positivos++;
        }
        else if (n2 < 0) {
            negativos++;
        }

        if (n3 % 2 == 0) {
            pares++;
        }
        else {
            impares++;
        }
        if (n3 > 0) {
            positivos++;
        }
        else if (n3 < 0) {
            negativos++;
        }

        if (n4 % 2 == 0) {
            pares++;
        }
        else {
            impares++;
        }
        if (n4 > 0) {
            positivos++;
        }
        else if (n4 < 0) {
            negativos++;
        }

        if (n5 % 2 == 0) {
            pares++;
        }
        else {
            impares++;
        }
        if (n5 > 0) {
            positivos++;
        }
        else if (n5 < 0) {
            negativos++;
        }

        Console.WriteLine(pares + " valor(es) par(es)");
        Console.WriteLine(impares + " valor(es) impar(es)");
        Console.WriteLine(positivos + " valor(es) positivo(s)");
        Console.WriteLine(negativos + " valor(es) negativo(s)");
        
        Console.ReadLine();
    }
}

//Exercício Beecrowd 1070:

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int x;

        x = int.Parse(Console.ReadLine());

                
        if (x % 2 == 0) {
            x = x + 1;
        }

        Console.WriteLine(x);
        Console.WriteLine(x + 2);
        Console.WriteLine(x + 4);
        Console.WriteLine(x + 6);
        Console.WriteLine(x + 8);
        Console.WriteLine(x + 10);

        Console.ReadLine();
    }
}