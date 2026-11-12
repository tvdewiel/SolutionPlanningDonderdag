using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningInterfaces.Domein
{
    public class Planner
    {
        List<Taak> alleTaken = new();
        IPlanningsMethode PlanningsAanpak;

        public Planner(List<Taak> alleTaken, IPlanningsMethode planningsAanpak)
        {
            this.alleTaken = alleTaken;
            PlanningsAanpak = planningsAanpak;
        }

        public Planning MaakPlanning()
        {
            return PlanningsAanpak.MaakPlanning(alleTaken);
        }
    }
}
