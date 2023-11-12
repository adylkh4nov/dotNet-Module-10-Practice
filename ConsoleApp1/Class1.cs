using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_Module_10_Practice
{
    public class Class
    {
        public static void Main()
        {
            House house = new House();
            Team team = new Team();

            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLid());

            team.Work(house);

            Console.ReadLine();
        }
    }
}
