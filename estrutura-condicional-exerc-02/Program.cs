using System;
class Program {
    static void Main(string[] args) {

        int x, y, z;

        string[] valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);
        z = int.Parse(valores[2]);

        if (x < y && x < z) {
            Console.WriteLine("Menor = " + x);
        }   
        else if (y < z) {
            Console.WriteLine("Menor = " + y);
        } 
        else {
            Console.WriteLine("Menor = " + z);            
        }     

        Console.ReadLine();       
    }
}