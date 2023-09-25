using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eigenshappen
{
    internal class GetalString
    {
        public string Getal { get; set; }

        public GetalString(string Getal)
        {
            string getalProper = Regex.Replace(value, "[^0-9-]", "");

            if (string.IsNullOrEmpty(getalProper) || getalProper == "-")
            {
                Getal = "0";
            }
            
            else
            {
                Getal = getalProper;
            }
        }

        public override string ToString()
        {
            return "de tekst is:" + Getal;
        }

    }
}
