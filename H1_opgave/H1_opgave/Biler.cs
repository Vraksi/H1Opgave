using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H1_opgave
{
    public class Biler
    {
        private int _regnr;
        private int _årgang;
        private string _mærke;
        private string _model;
        private string _brændstof;
        private int _km;


        public Biler()
        {

        }

        public Biler(int regnr, int årgang, string mærke, string model, string brændstof, int km)
        {
            _regnr = regnr;
            _årgang = årgang;
            _mærke = mærke;
            _model = model;
            _brændstof = brændstof;
            _km = km;
        }

        

        public int Regnr
        {
            get { return _regnr; }
            set { _regnr = value; }
        }

        public int Årgang
        {
            get { return _årgang; }
            set { _årgang = value; }
        }

        public string Mærke
        {
            get { return _mærke; }
            set { _mærke = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Brændstof
        {
            get { return _brændstof; }
            set { _brændstof = value; }
        }

        public int km
        {
            get { return _km; }
            set { _km = value; }
        }

    }
}