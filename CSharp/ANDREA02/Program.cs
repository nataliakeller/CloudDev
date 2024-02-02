namespace ANDREA02;
using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        /*    var text = "";
           var sw = new Stopwatch();
           sw.Start();
           for (int i = 0; i < 10000; i++);
           {;
               text += "abc" + i;
           };

           sw.Stop();
           Console.WriteLine($"Elapse: { sw.ElapsedMilliseconds} ms");


           var sb = new StringBuilder();
           sw.Restart();

           for (int i = 0; i < 10000; i++);
           {;
               sb.Append(i);
           };
           sw.Stop();
           Console.WriteLine($"String Builder Elapsed: { sw.ElapsedMilliseconds} ms"); */

        //esercizio 01
        // var input = new StringBuilder();

        // Console.WriteLine("Inserisca una stringa: ");

        // input.Append(Console.ReadLine());

        // Console.WriteLine($"The string you entered is: {input}");

        //esercizio 02
        // var stringLength = input.Length;
        // Console.WriteLine($"Length of the string is: {stringLength}");

        // esercizio 03

        //string stringa = "w3resource.com";
        /*foreach(char lettere in stringa){
            Console.Write($"{lettere} ");
        }*/


        // esercizio 04

        /*for (int i = stringa.Length - 1; i >= 0; i--)
        {
            Console.Write($"{stringa[i]} ");
        }*/


        // esercizio 05

        //string stringa = "This is C# Lesson";


        //Console.WriteLine($"Number of words: {stringa.Split(' ', '\t', '\n', '\r').Length}");

        // esercizio 06

        // string stringa1 = "This is first string";

        // string stringa2 = "This is first string";

        // if(stringa1 == stringa2){
        //     Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
        // }
        // else {
        //     Console.WriteLine("Not equal");

        // }

        // esercizio 07

        // string stringa = "Welcome to w3resource.com";
        // int digitsCounter = 0;
        // int alphabetsCounter = 0;
        // int specialCounter = 0;

        // foreach (char lettere in stringa)
        // {


        //     if (char.IsAsciiLetter(lettere))
        //     {
        //         alphabetsCounter++;
        //     }
        //     else if (char.IsDigit(lettere))
        //     {
        //         digitsCounter++;

        //     }
        //     else
        //     {
        //         specialCounter++;
        //     }



        // }

        // Console.WriteLine($"Number of Alphabets in the string is: {alphabetsCounter}");
        // Console.WriteLine($"Number of Digits in the string is: {digitsCounter}");
        // Console.WriteLine($"Number of Specials in the string is: {specialCounter}");

        // esercizio 08
        //boh

        // esercizio 09
        string stringa = "Welcome to w3resource.com";
        foreach(char lettera in stringa){
            char.ToLower(lettera);

        }

        Console.WriteLine($"{stringa}");

    }
}

