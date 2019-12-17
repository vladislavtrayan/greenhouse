using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentModulation
{
    public class Environment : IEnvironment
    {
        public (Area, Cell[][] values) Matrix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public enum Area
        {
            AirTemperature,
            WaterTemperature
        }

        public class Cell
        {
            public double value;
            public bool IsConst;
        }

        public Environment()
        {
        }
    }
}
