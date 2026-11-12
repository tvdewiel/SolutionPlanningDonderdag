using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningClassic.Domein
{
    public class Planner
    {
        List<Taak> alleTaken = new();


        public Planning MaakPlanning(string methode)
        {
            switch (methode)
            {
                case "duur" :
                    List<Taak> takenTmp1 = alleTaken.OrderBy(x => x.Duurtijd).ToList();
                    Planning planning1 = new Planning();
                    planning1.Taken = takenTmp1;
                    return planning1;
                case "prioriteit":
                    List<Taak> takenTmp2 = alleTaken.OrderByDescending(x => x.Prioriteit).ToList();
                    Planning planning2 = new Planning();
                    planning2.Taken = takenTmp2;
                    return planning2;
            }
            return null;
        }
    }
}
