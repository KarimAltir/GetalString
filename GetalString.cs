using System.Text.RegularExpressions;

namespace Eigenshappen
{
    internal class GetalString
    {
        public string Getal { get; set; }

        public GetalString(string Getal)
        {
            string getalProper = Regex.Replace(Getal, "[^0-9-]", "");

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
            return "de tekst is: " + Getal;
        }

    }
}
