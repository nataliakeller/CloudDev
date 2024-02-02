namespace andreacorso;
using System;



class Program
{
    static void Main(string[] args)
    {
        // string? n1;
        // int i = 0;
        
        
        // Console.WriteLine("Digita un numero \b");
        // n1 = Console.ReadLine();
        
        
        

        // while(i<5){
        //     if(i == 0 || i == 4){
        //         Console.WriteLine("{0}{0}{0}", n1);
                
        //     } else{

        //         Console.WriteLine("{0} {0}", n1);

        //     }

           
        //     i++;
        // }


        // double tempC;
        
        // double tempF;
        
        // double tempK;
        
        // Console.WriteLine("Insert");
        
        // tempC = Convert.ToDouble(Console.ReadLine());
        
        // tempF = tempC*(1.8)+32;
        // tempK = tempC+273;

        // Console.WriteLine($"{tempC} c = {tempF}f = {tempK}");

      
       Console.WriteLine("Quanti interi vuoi inserire");
       string? s = Console.ReadLine();
       int qta = Convert.ToInt32(s);

       int sum = 0;
        for (int i = 0; i < qta; i++)
        {
            Console.Write("Numero: ");
            string? stringa = Console.ReadLine();
            sum += Convert.ToInt32(stringa);
            
        }

       
       double reslt = sum /(double)qta;
    }
    
}
