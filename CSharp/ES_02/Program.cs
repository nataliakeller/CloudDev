namespace ES_02;

class Program
{
    static void Main(string[] args)
    {/* 
        string scelta = "";
        do {
            Console.WriteLine("MENU\n");
            Console.WriteLine("A = Prima Opzione\n");
            Console.WriteLine("B = Seconda Opzione\n");
            Console.WriteLine("C = Terza Opzione\n");
            Console.WriteLine("Premi invio per terminare\n");

            Console.Write("Scegli opzione ---> [ ]\b\b");
            scelta = Console.ReadLine();
            Console.WriteLine("Hai scelto l'opzione {scelta}");
            
            Console.ReadKey(true);
            Console.Clear();
            
            Console.WriteLine("premi un tasto per continuare");
            
        }
        while(scelta != ""); */

        
        /*while(n < 500){
            //n++;
            //Console.Write("{0} ", n);
            
            //if(n%2 == 1 && n < 100) Console.Write("{0}  ", n);

            //if(n<50) Console.Write("{0} ", n * 7);
            
            
           
            
        }*/

        int n = 0;
        
        while(n < 100){
            n+= n;
            n++;
        }
    
        Console.Write("{0}", n);
    }
}
