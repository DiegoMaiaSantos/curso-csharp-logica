//Exercício Beecrowd 1035:

using System;

class Program {

    static void Main(string[] args) {

        int a, b, c, d;

        string[] valores = Console.ReadLine().Split(' ');
        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);
        d = int.Parse(valores[3]);

        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0) {
            Console.WriteLine("Valores aceitos");
        }
        else {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}

//Exercício Beecrowd 1038:

using System;
using System.Globalization;

class Program {

    static void Main(string[] args) {

        int codigo, quantidade;
        double valorTotal;

        string[] valores = Console.ReadLine().Split(' ');
        codigo = int.Parse(valores[0]);
        quantidade = int.Parse(valores[1]);

        if (codigo == 1) {
            valorTotal = 4.0 * quantidade;
            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        } 
        else if (codigo == 2) {
            valorTotal = 4.5 * quantidade;
            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }   
        else if (codigo == 3) {
            valorTotal = 5.0 * quantidade;
            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }   
        else if (codigo == 4) {
            valorTotal = 2.0 * quantidade;
            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }   
        else {
            valorTotal = 1.5 * quantidade;
            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.ReadLine();    
    }
}

//Exercício Beecrowd 1044:

using System;
using System.Globalization;

class Program {

    static void Main(string[] args) {

        int a, b;

        string[] valores = Console.ReadLine().Split(' ');
        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);

        if (a % b == 0 || b % a == 0) {
            Console.WriteLine("São multiplos");
        }
        else {
            Console.WriteLine("Não são multiplos");
        }       

        Console.ReadLine();    
    }
}

//Exercício Beecrowd 1046:

using System;
using System.Globalization;

class Program {

    static void Main(string[] args) {   

        int horaInicio, horaFinal, tempoJogo;

        string[] valores = Console.ReadLine().Split(' ');
        horaInicio = int.Parse(valores[0]);
        horaFinal = int.Parse(valores[1]);  
        
        if (horaInicio < horaFinal) {
            tempoJogo = horaFinal - horaInicio;
        }
        else {
            tempoJogo = 24 - horaInicio + horaFinal;
        }

        Console.WriteLine("O JOGO DUROU " + tempoJogo + " HORA(S)");

        Console.ReadLine();    
    }
}

//Exercício Beecrowd 1048:

using System;
using System.Globalization;

class Program {

    static void Main(string[] args) {   

        double salario, novoSalario, reajuste, porcentagem;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario <= 400.0) {
            porcentagem = 15.0;
        }
        else if (salario <= 800.0) {
            porcentagem = 12.0;
        }
        else if (salario <= 1200.0) {
            porcentagem = 10.0;
        }
        else if (salario <= 2000.0) {
            porcentagem = 7.0;
        }
        else {
            porcentagem = 4.0;
        }  

        reajuste = salario * porcentagem / 100.0;
        novoSalario = salario + reajuste;
       
        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + porcentagem.ToString("F0", CultureInfo.InvariantCulture) + " %");

        Console.ReadLine();    
    }
}