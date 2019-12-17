using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class DaySchedule
    {
        public int Day;

        public string LightSensorOptimalValue { get ; set ; }
        public string AirTempretureSensorOptimalValue { get ; set ; }
        public string WetSensorOptimalValue { get ; set ; }
        public string AcidSensorOptimalValue { get ; set ; }
        public string NutrientSensorOptimalValue { get ; set ; }
        public string WaterTemperatureSensorOptimalValue { get ; set ; }
        public string LightSensorMaxDeviation { get ; set ; }
        public string AirTempretureSensorMaxDeviation { get ; set ; }
        public string WetSensorMaxDeviation { get ; set ; }
        public string AcidSensorMaxDeviation { get ; set ; }
        public string NutrientSensorMaxDeviation { get ; set ; }
        public string WaterTemperatureSensorMaxDeviation { get ; set ; }
        public Time LightSensorStartTime { get ; set ; }
        public Time AirTempretureSensorStartTime { get ; set ; }
        public Time WetSensorStartHour { get ; set ; }
        public Time AcidSensorStartHour { get ; set ; }
        public Time NutrientSensorStartHour { get ; set ; }
        public Time WaterTemperatureSensorStartHour { get ; set ; }
        public Time LightSensorEndTime { get ; set ; }
        public Time AirTempretureSensorEndTime { get ; set ; }
        public Time WetSensorEndTime { get ; set ; }
        public Time AcidSensorEndTime { get ; set ; }
        public Time NutrientSensorEndTime { get ; set ; }
        public Time WaterTemperatureSensorEndTime { get ; set ; }
    }
}
