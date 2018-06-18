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
        List<string> _bilList = new List<string>();
        List<string> _Kunde = new List<string>();


        public Kunde()
        {

        }        
        
        public void AddCar()
        {
            
        }
        
        public void AddKunder()
        {
            Console.Clear();
            Console.WriteLine("Hvad er hans/huns kunde");
            _Kunde.Add(Console.ReadLine());                       
            Console.WriteLine("Han/huns fuldenavn");
            _Kunde.Add(Console.ReadLine());            
            Console.WriteLine("Oprettelses Dato");
            _Kunde.Add(Console.ReadLine());
            Console.WriteLine("Hvad er hans Bil ID");
            _Kunde.Add(Console.ReadLine());


            string linje = String.Join(", ", _Kunde.ToArray());
            linje = linje + "\n";
            File.AppendAllText("Kunde.dat", linje, Encoding.Unicode);
            Console.WriteLine(linje);
            Console.ReadKey();
            _Kunde.Clear();
            Console.Clear();
            return;
        }

        public void VisKunde()
        {

        }
    }
}