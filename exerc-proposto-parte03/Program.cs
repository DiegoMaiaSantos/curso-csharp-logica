// Exercício Beecrowd 1018 (mod %)

using System; 

class URI {

    static void Main(string[] args) { 

        int n, quociente, resto, nota;

        n = int.Parse(Console.ReadLine());
        Console.WriteLine(n);

        resto = n;

        nota = 100;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 50;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 20;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 10;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00"); 
        resto = resto % nota;

        nota = 5;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;
        
        nota = 2;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;   

        Console.WriteLine(resto + " nota(s) de R$ 1,00");    
    }

}


// Exercício beecrowd 1020 (mod %)

using System; 

class URI {

    static void Main(string[] args) { 

        int n, anos, meses, dias, resto;

        n = int.Parse(Console.ReadLine());

        anos = n / 365;
        resto = n % 365;
        meses = resto / 30;
        dias = resto % 30;

        Console.WriteLine(anos + " anos(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");        
    }

}

// Exercício beecrowd 1021

using System; 

class URI {

    static void Main(string[] args) { 

        
    }

}