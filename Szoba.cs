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

        //Konstruktor
        public virtual string szobaszamesalapar()
        {
            return $"A szoba száma: {SzobaSzam}, az alapár: {Alapar}";
        }

        //Metódusok


        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            int ejsz = ejszakakSzama * Alapar;
            return ejsz;
        }

        public override string ToString()
        {
            return $"Szoba [Szobaszam] | Alapár: [Alapar] Ft/éj";
        }
        }
       public override int ArKiszamitas(int ejszakakSzama



    }
}
