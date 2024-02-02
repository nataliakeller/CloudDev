using System.Dynamic;
using System;

namespace ES_04;

class Mymath
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//def di un metodo di classe 
//metodo di classe: con la parola static
//perche non è necessario creare un oggetto della classe


public static long Cube(long number)
{
    long rest;
    rest = number * number * number;
    return rest;

}
// definizione di un metodo di istanza
public double Sqrt(double number) {
    double val;
    val = Math.Sqrt(number);
    return val;
}

class MethodInvocation {
    public static void ExecCube{
        long Cnumber;
        Console.Write(" DIGITA un numero di cui far calcolare il cybo ");
        Cnumber= ConvertBinder.ToInt64(Console.Readline());
        while (CNumber <- 1000 && CNumber>1000)
        {
            Console.Write("Il numero deve essere compreso tra -1000 e 1000");
        }
    }
}

