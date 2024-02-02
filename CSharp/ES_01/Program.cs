using System;
using System.Text;
namespace ES_01;

class Program
{
    static void Main(string[] args)
    {
       /*  float test = 10.25f;
        int a = 10, b = 20, somma;
        somma = a+b;
        Console.WriteLine("La somma di "+a+" e "+b+" è uguale a "+somma);
        Console.WriteLine("la somma di {0} e {1} è uguale a {2}", a, b, somma); */
        

        // int number;
        // Console.Write("Numero da convertire: ");
        // number = Convert.ToInt32(Console.ReadLine()); // 
        // Console.WriteLine("il numero {0} convertito in binario è {1} ", number, Convert.ToString(number, 2));
        // Console.WriteLine("il numero {0} convertito in 8 è {1} ", number, Convert.ToString(number, 8));
        // Console.WriteLine("il numero {0} convertito in 16 è {1} ", number, Convert.ToString(number, 16));

        // decimal amount = 4546890m; // un letterale decimal - suffisso m
        //Console.OutputEncoding = Encoding.UTF8;
        // Console.WriteLine("Ammontare:{0:C}", amount);

        int ch;
        Console.Write("Inserisci il carattere minuscolo da convertire [ ]\b\b");
        ch = Console.Read();
        int ch_U = TransformaMaiusc(ch);
        Console.WriteLine("Il carattere {0} viene trasformato in maiuscolo {1}", (char)ch, (char)ch_U);
    }

    
    public static int TransformaMaiusc(int ch){
        int charUP;
        if(ch>= 'a'&& ch<='z'){
            charUP = ch - 'a' + 'A';
            return charUP;
        }

        return ch;
    }

}
