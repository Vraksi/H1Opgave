using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace H1_opgave
{
    public class Kunde
    {
        int linietæller;
        List<string> _værkstedsbesøg = new List<string>();
        List<string> _Kunde = new List<string>();        

        public Kunde()
        {

        }
        
        public void VærkstedBesøg()
        {
            Console.WriteLine("\nHvad dato er begyndte værkstedet");
            _værkstedsbesøg.Add(Console.ReadLine());
            Console.WriteLine("Hvad blev der lavet på Værkstedet");
            _værkstedsbesøg.Add(Console.ReadLine());
            Console.WriteLine("Hvornår er vi færdige med den");
            _værkstedsbesøg.Add(Console.ReadLine());
            string linje = String.Join(", ", _værkstedsbesøg.ToArray());            
            File.AppendAllText("Vearkstedsbesog.txt", linje + Environment.NewLine);
            Console.WriteLine(linje);
            Console.ReadKey();
            _værkstedsbesøg.Clear();
            Console.Clear();
            return;
        }
        
        public void AddKunder()
        {
            Console.Clear();
            Console.WriteLine("Hans/huns Bil ID");
            _Kunde.Add(Console.ReadLine());
            Console.WriteLine("Hans/huns Kunde id");
            _Kunde.Add(Console.ReadLine());     
            Console.WriteLine("Han/huns fulde navn");
            _Kunde.Add(Console.ReadLine());            
            Console.WriteLine("Oprettelses Dato");
            _Kunde.Add(Console.ReadLine());
            

            string linje = String.Join(", ", _Kunde.ToArray());            
            File.AppendAllText("Kunde.txt", linje + Environment.NewLine);
            Console.WriteLine(linje);
            Console.ReadKey();
            _Kunde.Clear();
            Console.Clear();
            return;
        }

        public void VisKunde()
        {
            String[] linier = File.ReadAllLines("Kunde.txt");
            foreach (string indhold in linier)                              // her giver info til indhold og skriver det op
            {
                Console.WriteLine(indhold);

                linietæller++;                                              // her tæller en gang
                if (linietæller == 15)                                      // her limiter vi linjer med 15
                {
                    Console.WriteLine("skærmen er fuld tryk en tast for flere"); Console.ReadKey(); // et break for at give personen en chance for læse information
                    Console.Clear();
                    linietæller = 0;
                }
            }
            Thread.Sleep(2000);
        }

        public void ViskundeBiler()
        {
            string strSøg;
            String[] linier = File.ReadAllLines("Bil.txt" );
            String[] linjer = File.ReadAllLines("Kunde.txt" );
            Console.Write("\nSkriv BilID du vil søge på \n");
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

            foreach (string linje  in linjer)
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

        public void Visværkstedsbesøg()
        {
            String[] linier = File.ReadAllLines("Vearkstedsbesog.txt" );
            foreach (string indhold in linier)                              // her giver info til indhold og skriver det op
            {
                Console.WriteLine(indhold);

                linietæller++;                                              // her tæller en gang
                if (linietæller == 15)                                      // her limiter vi linjer med 15
                {
                    Console.WriteLine("skærmen er fuld tryk en tast for flere"); Console.ReadKey(); // et break for at give personen en chance for læse information
                    Console.Clear();
                    linietæller = 0;
                }
            }
            Thread.Sleep(2000);
        }
    }
}