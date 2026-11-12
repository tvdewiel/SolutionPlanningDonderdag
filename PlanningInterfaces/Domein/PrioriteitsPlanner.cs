using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningInterfaces.Domein
{
    public class PrioriteitsPlanner : IPlanningsMethode
    {
        public Planning MaakPlanning(List<Taak> taken)
        {
            List<Taak> takenTmp= taken.OrderByDescending(x=>x.Prioriteit).ToList();
            Planning planning=new Planning();
            planning.Taken= takenTmp;
            return planning;
        }
    }
}
