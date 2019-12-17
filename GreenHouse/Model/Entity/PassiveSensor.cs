using EnvironmentModulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class PassiveSensor : Sensor
    {
        private double _value;
        public double GetData()
        {
            return _value;
        }

        public void SetValue(double value)
        {
            _value = value;
        }

        public PassiveSensor(IEnvironment environment) : base(environment)
        {

        }
    }
}
