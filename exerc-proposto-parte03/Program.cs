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
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double n;
        int quociente, resto, nota, moeda;

        n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        resto = (int)(n * 100 + 0.5);   

        Console.WriteLine("NOTAS:");    

        nota = 100;
        quociente = resto / (nota * 100);  
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100);

        nota = 50;
        quociente = resto / (nota * 100);  
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100);

        nota = 20;
        quociente = resto / (nota * 100);
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100);

        nota = 10;
        quociente = resto / (nota * 100);
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100);

        nota = 5;
        quociente = resto / (nota * 100);
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); 

        nota = 2;
        quociente = resto / (nota * 100);
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); 

        Console.WriteLine("MOEDAS:");

        moeda = 100;
        quociente = resto / moeda;
        Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
        resto = resto % moeda; 

        moeda = 50;
        quociente = resto / moeda;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
        resto = resto % moeda;

        moeda = 25;
        quociente = resto / moeda;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
        resto = resto % moeda;


        moeda = 10;
        quociente = resto / moeda;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
        resto = resto % moeda;


        moeda = 5;
        quociente = resto / moeda;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
        resto = resto % moeda;


        Console.WriteLine(resto + " moeda(s) de R$ 0.01");
    }

}

// Exercício beecrowd 1021

using System; 

class URI {

    static void Main(string[] args) { 

        int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, inicio, fim, duracao, resto;

        string[] valores = Console.ReadLine().Split(' ');
        w1 = int.Parse(valores[1]);

        valores = Console.ReadLine().Split(' ');
        x1 = int.Parse(valores[0]);
        y1 = int.Parse(valores[2]);
        z1 = int.Parse(valores[4]);

        valores = Console.ReadLine().Split(' ');
        w2 = int.Parse(valores[1]);

        valores = Console.ReadLine().Split(' ');
        x2 = int.Parse(valores[0]);
        y2 = int.Parse(valores[2]);
        z2 = int.Parse(valores[4]);

        inicio = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
        fim = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

        duracao = fim - inicio;

        w = duracao / (24 * 60 * 60);
        resto = duracao % (24 * 60 * 60);
        x = resto / (60 * 60);
        resto = resto % (60 * 60);
        y = resto / 60;
        z = resto % 60;

        Console.WriteLine(w + " dia(s)");
        Console.WriteLine(x + " hora(s)");
        Console.WriteLine(y + " minuto(s)");
        Console.WriteLine(z + " segundo(s)");               
    }

}