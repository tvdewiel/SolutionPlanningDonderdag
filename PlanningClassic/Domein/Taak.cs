using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningClassic.Domein
{
    public class Taak
    {
        public Taak(string naam, DateTime deadline, int prioriteit, int duurtijd, Medewerker medewerker)
        {
            Naam = naam;
            Deadline = deadline;
            Prioriteit = prioriteit;
            Duurtijd = duurtijd;
            Medewerker = medewerker;
        }

        public string Naam { get; set; }
        public DateTime Deadline { get; set; }
        public int Prioriteit { get; set; } //0:laagste
        public int Duurtijd { get; set; } //min
        public Medewerker Medewerker { get; set; }
        public override string ToString()
        {
            return $"{Naam},prioriteit:{Prioriteit},duurtijd:{Duurtijd},deadline:{Deadline}";
        }
    }
}
