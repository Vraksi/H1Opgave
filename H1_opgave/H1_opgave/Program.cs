using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_opgave
{
    class Program
    {
        static void Main(string[] args)
        {            
            Kunde Kunder = new Kunde();
            string svar;
            Console.WriteLine("Tryk på den tast for at starte");
            ConsoleKeyInfo info = Console.ReadKey();
            Console.Clear();
                       
            Console.WriteLine("Du er nu ankommet til Værkstedet hvad vil du gøre ");
            Console.WriteLine("Du kan nu vælge hvad ud gerne vil gøre på værkstedet" +
                    "O for oprettelse af kunde, V for vise kunde oversigt, B for Biler, U for opdatering \n");            
            // vi laver en do while loop for at kunne komme ud af programmet når vi hvar lyst sammen samt blive i programmet til vi ikke gider mere
            do
            {
                info = Console.ReadKey();
                svar = Convert.ToString(info.KeyChar);
                Console.WriteLine("O for oprettelse af kunde, V for vise kunde oversigt, B for Biler, U for opdatering \n");
                 // O for at oprette en kunde
                 if (svar == "o" || svar == "O")
                 {
                     Kunder.AddKunder();
                 }
                 
                 // V for at vise vores kunde oversigt
                 if (svar == "V" || svar == "v")
                 {
              
                 }
                 
                 // B for at opdatere, vise, slette eller vise en bil
                 if (svar == "B" || svar == "b")
                 {
                    
                 }
                 
                 // U for at opdatere, rette eller slette et værksteds besøg
                 if (svar == "U" || svar == "u")
                 {
              
                 }


            } while (svar != "Q" || svar != "q");
        }
    }
}
