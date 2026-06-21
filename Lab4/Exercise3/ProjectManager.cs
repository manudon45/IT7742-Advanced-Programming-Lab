using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class ProjectManager : IWorker, ILeader
    {
        public void PerformWork()
        {
            Console.WriteLine("Project Manager is performing work.");
        }

        public void LeadTeam()
        {
            Console.WriteLine("Project Manager is leading the team.");
        }

        public void MakeReports()
        {
            Console.WriteLine("Project Manager is creating reports.");
        }
    }
}
