using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningClassic.Domein
{
    public class Planning
    {
        public string Naam { get; set; }
        public List<Taak> Taken { get; set; }
        public override string ToString()
        {
            string takenstring=string.Join(", ", Taken);
            return $"{Naam},aantal taken{Taken.Count},{takenstring}";
        }
    }
}
