using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningInterfaces.Domein
{
    public class Medewerker
    {
        public Medewerker(string naam)
        {
            Naam = naam;
        }

        public string Naam {  get; set; }
    }
}
