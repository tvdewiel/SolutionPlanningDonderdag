using PlanningInterfaces.Domein;

namespace PlanningInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak aantal taken 
            Medewerker jos = new Medewerker("Jos");
            List<Taak> taken = new();
            taken.Add(new Taak("Licht repareren", DateTime.Now, 5, 30, jos));
            taken.Add(new Taak("Vloer repareren", DateTime.Now.AddDays(1), 1, 120, jos));
            taken.Add(new Taak("Afvoer repareren", DateTime.Now.AddDays(10), 2, 450, jos));

            //kies planningsmethode
            Console.WriteLine("Geef planningsmethode (prioriteit,duur,deadline):");
            string methode=Console.ReadLine();
            //maak planner
            Planner planner=null;

            planner=new Planner(taken,PlanningsMethodeFactory.GeefPlanningsMethode(methode));
                //maak planning
            Planning planning = planner.MaakPlanning();
            planning.Naam = "donderdagplanning";
            //toon planning
            Console.WriteLine(planning);
        }
    }
}
