using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface ISetSensorsSchduleService : IService
    {
        #region properties
        int CurrentDay { get; set; }


        string LightSensorOptimalValue { get; set; }
        string AirTempretureSensorOptimalValue { get; set; }
        string WetSensorOptimalValue { get; set; }
        string AcidSensorOptimalValue { get; set; }
        string NutrientSensorOptimalValue { get; set; }
        string WaterTemperatureSensorOptimalValue { get; set; }
        string LightSensorMaxDeviation { get; set; }
        string AirTempretureSensorMaxDeviation { get; set; }
        string WetSensorMaxDeviation { get; set; }
        string AcidSensorMaxDeviation { get; set; }
        string NutrientSensorMaxDeviation { get; set; }
        string WaterTemperatureSensorMaxDeviation { get; set; }
        Time LightSensorStartTime { get; set; }
        Time AirTempretureSensorStartTime { get; set; }
        Time WetSensorStartHour { get; set; }
        Time AcidSensorStartHour { get; set; }
        Time NutrientSensorStartHour { get; set; }
        Time WaterTemperatureSensorStartHour { get; set; }
        Time LightSensorEndTime { get; set; }
        Time AirTempretureSensorEndTime { get; set; }
        Time WetSensorEndTime { get; set; }
        Time AcidSensorEndTime { get; set; }
        Time NutrientSensorEndTime { get; set; }
        Time WaterTemperatureSensorEndTime { get; set; }
        #endregion properties

        DaySchedule GenerateDaySchedule();
    }
}
