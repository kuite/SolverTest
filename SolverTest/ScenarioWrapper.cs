using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverTest
{
    public class ScenarioWrapper : IWrapper
    {
        private ScenarioState _state;

        public ScenarioWrapper(ScenarioState state)
        {
            _state = state;
        }

        public double GetDllSymbol(string symbol)
        {
            //todo

            return 0;
        }
    }
}
