using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var scenario = new ScenarioParser().GetScenario("sample path to scenario");
        }
    }
}
