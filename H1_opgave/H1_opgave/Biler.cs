﻿using System;
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

        List<string> _Biler = new List<string>();
        public Biler()
        {

        }


        public void AddBiler()
        {
            Console.Clear();
            Console.WriteLine("Hvad er bilens ID? ");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvad er bilens Reg nr?");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvilket årgang er bilen");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvilket mærke er bilen");
            _Biler.Add(Console.ReadLine());
            Console.WriteLine("Hvilken type Brændstof bruges?");
            _Biler.Add(Console.ReadLine());
            

            string linje = String.Join(", ", _Biler.ToArray());
            linje = linje + "\n";
            File.AppendAllText("Bil.txt", linje, Encoding.Unicode);
            Console.WriteLine(linje);
            Console.ReadKey();
            _Biler.Clear();
            Console.Clear();
            return;
        }

        public void SletBil()
        {

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