using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int codigoPeca1, quantidadePeca1, codigoPeca2, quantidadePeca2;
        double valorPeca1, valorPeca2, totalPagamento;

        string[] valores = Console.ReadLine().Split(' ');
        codigoPeca1 = int.Parse(valores[0]);
        quantidadePeca1 = int.Parse(valores[1]);
        valorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        codigoPeca2 = int.Parse(valores[0]);
        quantidadePeca2 = int.Parse(valores[1]);
        valorPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        totalPagamento = valorPeca1 * quantidadePeca1 + valorPeca2 * quantidadePeca2;

        Console.WriteLine("Valor a pagar: R$" + totalPagamento.ToString("F2", CultureInfo.InvariantCulture));


        Console.ReadLine();
    }
}

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        double valorRaio, area;

        valorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = 3.14159 * Math.Pow(valorRaio, 2.0);

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


        Console.ReadLine();
    }
}

using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int codigoProduto, quantidadeProduto;
        double valorProduto;

        string[] valores = Console.ReadLine().Split(' ');
        codigoProduto = int.Parse(valores[0]);
        quantidadeProduto = int.Parse(valores[1]);

        if (codigoProduto == 1) {
            valorProduto = 4.00 * quantidadeProduto;
            Console.WriteLine("Cachorro Quente: R$ " + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
        } 
        else if (codigoProduto == 2) {
            valorProduto = 4.50 * quantidadeProduto;
            Console.WriteLine("X-Salada: R$ " + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (codigoProduto == 3) {
            valorProduto = 5.00 * quantidadeProduto;
            Console.WriteLine("X-Bacon: R$ " + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (codigoProduto == 4) {
            valorProduto = 2.00 * quantidadeProduto;
            Console.WriteLine("Torrada simples: R$ " + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else {
            valorProduto = 1.50 * quantidadeProduto;
            Console.WriteLine("Refrigerante: R$" + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
        }  

        Console.ReadLine();
    }
}