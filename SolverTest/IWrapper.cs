using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverTest
{
    public interface IWrapper
    {
        double GetDllSymbol(string symbol);
    }
}
