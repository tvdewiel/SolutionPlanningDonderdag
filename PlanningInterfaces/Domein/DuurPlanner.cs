using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningInterfaces.Domein
{
    public class DuurPlanner : IPlanningsMethode
    {
        public Planning MaakPlanning(List<Taak> taken)
        {
            List<Taak> takenTmp=taken.OrderBy(x=>x.Duurtijd).ToList();
            Planning planning = new Planning();
            planning.Taken=takenTmp;
            return planning;
        }
    }
}
