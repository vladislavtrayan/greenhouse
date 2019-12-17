using EnvironmentModulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnvironmentModulation.Environment;

namespace Model.Entity
{

    public class Sensor : EntityBase,IDevice
    {
        private IEnvironment _environment;
        public bool IsActive { get; set; }
        public Area Area { get; set; }

        public Sensor(IEnvironment environment)
        {
            _environment = environment;
        }
    }
}
