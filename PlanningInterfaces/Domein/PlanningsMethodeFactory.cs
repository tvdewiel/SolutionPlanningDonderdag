using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningInterfaces.Domein
{
    public static class PlanningsMethodeFactory
    {
        public static IPlanningsMethode GeefPlanningsMethode(string methode)
        {
            switch (methode)
            {
                case "duur": return new DuurPlanner();
                case "prioriteit": return new PrioriteitsPlanner();
                case "deadline": return new DeadlinePlanner();
                default: return null;
            }
        }
    }
}
