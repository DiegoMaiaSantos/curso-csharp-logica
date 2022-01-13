using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double nota01, nota02, nota03, mediaAluno;
        
        nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        mediaAluno = ((nota01 * 2.0) + (nota02 * 3.0) + (nota03 * 5.0)) / 10.0;

        Console.WriteLine("MEDIA = " + mediaAluno.ToString("F1", CultureInfo.InvariantCulture));
    }

}