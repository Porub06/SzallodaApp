using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int SzobaSzam { get; set; }
        protected int alapAr = 10000;
        public int Alapar
        {
            get { return alapAr; }
            set {
                if (value > 0)
                alapAr = value; 
            }
        }

        public virtual string szobaszamesalapar()
        {
            return $"A szoba száma: {SzobaSzam}, az alapár: {Alapar}";
        }

    }
}
