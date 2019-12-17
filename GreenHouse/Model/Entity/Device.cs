using EnvironmentModulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EnvironmentModulation.Environment;

namespace Model.Entity
{
    public class Device : EntityBase,IDevice
    {
        private IEnvironment _environment;
        public bool IsOn { get; set; }
        public Area Area { get; set; }

        public Device(IEnvironment environment)
        {
            _environment = environment;
        }

        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }
    }
}
