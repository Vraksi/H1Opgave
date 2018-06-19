using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace H1_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Biler bil = new Biler();
            Kunde Kunder = new Kunde();
            string svar;
            Console.WriteLine("Tryk på den tast for at starte");
            ConsoleKeyInfo info = Console.ReadKey(); 
            Console.Clear();
                       
            Console.WriteLine("Du er nu ankommet til Værkstedet hvad vil du gøre ");

            // vi laver en do while loop for at kunne komme ud af programmet når vi hvar lyst sammen samt blive i programmet til vi ikke gider mere
            do
            {                
                Console.WriteLine("Du kan nu vælge hvad ud gerne vil gøre på værkstedet" +
                    "" +
                    "\n O for oprettelse af kunde, V for vise kunde oversigt, B for Biler, U for opdatering \n");
                info = Console.ReadKey(); // For at konvertere det til readkey til en string
                svar = Convert.ToString(info.KeyChar);                
                // O for at oprette en kunde
                if (svar == "o" || svar == "O")
                {
                    Console.WriteLine("vil du oprette en kunde eller vise kunden med alle de biler han har \n A for kunde + biler ellers U for Opret");
                    info = Console.ReadKey();
                    svar = Convert.ToString(info.KeyChar);
                    Console.WriteLine("");
                    if (svar == "o" || svar == "O")
                    {
                        Kunder.AddKunder();
                        Console.Clear();
                    }
                    else if (svar == "A" || svar == "a")
                    {
                        Kunder.ViskundeBiler();
                        Console.Clear();
                    }
                    else
                    {
                        svar = "";
                        Console.Clear();
                    }
                }

                // V for at vise vores kunde oversigt
                if (svar == "V" || svar == "v")
                {
                    Kunder.VisKunde();
                }

                // B for at opdatere, vise, slette eller vise en bil
                if (svar == "B" || svar == "b")
                {
                    Console.Clear();
                    Console.WriteLine("Vil du oprette en bil eller opdatere\n" +
                        "" +
                        " O for Opret, U for opdatere, V for at vise en bil");
                    info = Console.ReadKey();
                    svar = Convert.ToString(info.KeyChar);
                    if (svar == "U" || svar == "u")
                    {
                        bil.AddBiler();
                        Console.Clear();
                    }
                    else if (svar == "O" || svar == "o")
                    {
                        bil.AddBiler();
                        Console.Clear();
                    }
                    else if (svar == "V" || svar == "v")
                    {
                        bil.VisBil();
                        Console.Clear();
                    }
                    else
                    {
                        svar = "";
                        Console.Clear();
                    }
                }

                // U for at oprette, opdatere, rette eller slette et værksteds besøg
                if (svar == "U" || svar == "u")
                {
                    Console.WriteLine("Vil du oprette et værkstedsbesøg eller vil du have dem vist.");
                    Console.WriteLine("O for opret, V for at vise alle");
                    info = Console.ReadKey();
                    svar = Convert.ToString(info.KeyChar);
                    if (svar == "O" || svar == "o")
                    {
                        Kunder.VærkstedBesøg();
                        Console.Clear();
                    }
                    else if (svar == "v" || svar == "V")
                    {
                        Kunder.Visværkstedsbesøg();
                        Console.Clear();
                    }
                    else
                    {
                        svar = "";
                        Console.Clear();
                    }
                }
            } while (svar != "Q" || svar != "q");
        }        
    }
}
