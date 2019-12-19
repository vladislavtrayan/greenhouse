using EnvironmentModulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class ActiveSensor : Sensor
    {
        private double _baseValue;
        public void Measure()
        {

        }

        public void SetBaseValue(double value)
        {
            _baseValue = value;
        }

        public void SendData()
        {

        }

        public ActiveSensor(IEnvironment environment,ITimer timer) : base(environment,timer)
        {

        }
    }
}
