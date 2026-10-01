using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SzallodaApp
{
    internal class Lakosztaly : Szoba
    {
        public int ExtraszolgaltatasAr {
            get
            {
                return ExtraszolgaltatasAr;
                { }
            {
                
                
            }
            set;     }  //pld pezsgőfürdő, szobaszerviz

        public int LakosztalyAr
        {
            get
            {
                return Alapar + ExtraszolgaltatasAr;
            }
        }
        

            
        }
    }
}
