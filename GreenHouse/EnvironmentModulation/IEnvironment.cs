using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnvironmentModulation.Environment;

namespace EnvironmentModulation
{
    public interface IEnvironment
    {
        (Area, Cell[][] values) Matrix { get; set; }
    }
}
