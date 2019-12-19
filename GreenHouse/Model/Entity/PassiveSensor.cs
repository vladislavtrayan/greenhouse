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

        private void SetValue()
        {
            _value = (int)_environment.GetValue(Area,Position.x, Position.y);
        }

        public override void TimerTick(object sender, EventArgs e)
        {
            base.TimerTick(sender, e);
            SetValue();
        }

        public PassiveSensor(ITimer timer,IEnvironment environment) : base(environment,timer)
        {

        }
    }
}
