using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace H1_opgave
{
    public class Biler
    {

        //liste som vi brugter til at bevare input
        List<string> _Biler = new List<string>();
        //En default constructor
        public Biler()
        {

        }

        public void AddBiler()
        {
            // vi tilføjer alt information ned til en "list" af strings
            Console.Clear();
            Console.WriteLine("Hvad er bilens ID?");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvad er bilens Reg nr?");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvilket årgang er bilen");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvilket mærke er bilen");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvilken type Brændstof bruges?");
            _Biler.Add(Console.ReadLine());

            //her kommaseperere vi det, og samler ned i vores "Bil.txt" fil. Da den ikke har nogen sti, så bruger den programmets placering som default
            string linje = String.Join(", ", _Biler.ToArray());            
            File.AppendAllText("Bil.txt", linje + Environment.NewLine);
            Console.WriteLine(linje);
            Console.ReadKey();
            _Biler.Clear();
            Console.Clear();
            return;
        }
     
        public void VisBil()
        {
            string strSøg;
            String[] linier = File.ReadAllLines("Bil.txt", Encoding.Unicode);
            Console.Write("\nSkriv regnr du vil søge på \n");
            strSøg = Console.ReadLine();
            foreach (string linje in linier)
            {
                string[] felter = linje.Split(',');                         //her splitter vi informationen op i felter, så vi kan specifikt kalde efter Tlf nr             
                do
                {
                    if (strSøg == "")
                    {
                        Console.WriteLine("\nDu skal skrive noget");
                        strSøg = Console.ReadLine();
                    }
                } while (strSøg == "");

                if (felter[0] == strSøg)                                    //Her kigger den igennem alt information for at finde det der passer.
                {
                    foreach (string f in felter)
                    {
                        Console.WriteLine(f);
                    }
                }
            }
            Console.WriteLine("Tryk på en tast for komme tilbage");         //Et break for give personen en chance for læse informationen            
            Console.ReadKey();
            Console.Clear();
        }
    }
}