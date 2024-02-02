namespace ES_03;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        //stampa i primi 500 numeri
        // int i = 1;
        // while(i<=500)
        // {
        //     Console.Write($"{i++} ");

        // }


        /*int f = Convert.ToInt32(Console.ReadLine());

        String convert = Convert.ToString(f, 2);
        Console.WriteLine($"{convert}");*/


        //decimal to binary

        // int d = Convert.ToInt32(Console.ReadLine());
        // StringBuilder str = new StringBuilder();

        // while(d != 0){
        //     if(d%2 == 0){
        //         str.Insert(0, "0");
        //         
        //     } else {
        //         str.Insert(0, "1");
        //         
        //     }
        //    d = d / 2;

        // }

        //Console.WriteLine($"{str}");



        // string lettura;
        // Console.WriteLine("Quati anni hai?");
        // lettura = Console.ReadLine();

        // if (int.TryParse(lettura, out int eta) && eta >= 0 && eta <= 120)
        // {
        //     if (eta >= 18)
        //     {
        //         Console.WriteLine("Sei maggiorene.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Sei minorenne");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Devi inserire un valore numerico valido");
        // }0



        // esercizio conteggio lettera A

        // Console.WriteLine("Scriva una stringa");
        // string lettura = Console.ReadLine();

        // int upper = 0, notupper = 0;

        // foreach(char lettere in lettura) {
        //     if('a' == lettere) {
        //         upper++;
        //     } else if ('A' == lettere){
        //         notupper++;
        //     }
        // }

        // Console.WriteLine("Ci sono {0} a's e {1} A's", upper, notupper);


        // char c = '\0';

        // do
        // {
        //     c = Console.ReadKey().KeyChar;

        // } while (c!= '\r');

        // int conta = 0;
        // ConsoleKey ck = ConsoleKey.Spacebar;
        // while ((ck = Console.ReadKey().Key) != ConsoleKey.Enter)
        // {
        //     if ('Aa'.Contains(ck.ToString())) {
        //         conta++;
        //     }
        // }

        string lettura = Console.ReadLine();
        int punt = 0;
        int numeri = 0;
        int vocali = 0;
        int consonanti = 0;

        foreach(char lettere in lettura){
            if(char.IsPunctuation(lettere)){
                punt++;
            }
            else if(char.IsNumber(lettere)){
                numeri++;
            } else if("aeiou".Contains(char.ToLower(lettere))){

                vocali++;
            }else if(char.IsLetter(lettere)){
                consonanti++;
            }
        }

        Console.WriteLine("punteggiatura: {0} numeri: {1} vocali: {2} consonanti:{3}", punt, numeri, vocali, consonanti);

    }
}
