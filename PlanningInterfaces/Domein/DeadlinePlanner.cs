using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningInterfaces.Domein
{
    public class DeadlinePlanner : IPlanningsMethode
    {
        public Planning MaakPlanning(List<Taak> taken)
        {
            List<Taak> takenTmp=taken.OrderBy(x=>x.Deadline).ToList();
            Planning planning=new Planning();
            planning.Taken=takenTmp;
            return planning;
        }
    }
}
