using System;
using System.Collections.Generic;
using System.Text;

namespace DuneImperiumSpacesGenerator
{
    public class DuneImperiumResourceConversions
    {
    }

    public class DuneImperiumDefaultResourceConversions
    {
        Dictionary <string, double> Conversions { get; set; }

        public DuneImperiumDefaultResourceConversions()
        {
            Conversions = new Dictionary<string, double>();
            Conversions.Add("Solari", 1.0);
            Conversions.Add("Spice", 1.0);
            Conversions.Add("Water", 2.0);
            Conversions.Add("Troops", 1.0);
            Conversions.Add("Ships", 1.0);
        }
    }
}
