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
        int i;
        private string _kundeid;
        private string _fuldnavn;
        private string _bil;
        private string _oprettelse;
        List<string> _bilList = new List<string>();
        List<string> _Kunde = new List<string>();


        public Kunde()
        {

        }
        
        /*
        public Kunde(string kundeid, string fuldnavn, string bil, string oprettelse)
        {
            _kundeid = kundeid;
            _fuldnavn = fuldnavn;
            _bil = bil;
            _oprettelse = oprettelse;
        }
        */
        public void AddCar()
        {
            
        }
        
        public void AddKunder()
        {
            Console.Clear();
            i++;
            _Kunde.Add(Convert.ToString(i));           
            Console.WriteLine("Han/huns kundeid er {0}", i);            
            Console.WriteLine("Han/huns fuldenavn");
            _Kunde.Add(Console.ReadLine());            
            Console.WriteLine("Oprettelses Dato");
            _Kunde.Add(Console.ReadLine());

            string linje = String.Join(", ", _Kunde.ToArray());
            linje = linje + "\n";
            File.AppendAllText("Kunde.dat", linje, Encoding.Unicode);
            Console.WriteLine(linje);
            return;
        }

        public void VisKunde()
        {

        }
    }
}