using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Service
{
    public class SetSensorsScheduleService : ISetSensorsSchduleService
    {

        #region properties
        public int CurrentDay { get; set; }

        // TODO
        // ADD fields verification later

        private string _lightSensorOptimalValue = String.Empty;
        private string _airTempretureSensorOptimalValue = String.Empty;
        private string _wetSensorOptimalValue = String.Empty;
        private string _acidSensorOptimalValue = String.Empty;
        private string _nutrientSensorOptimalValue = String.Empty;
        private string _waterTemperatureSensorOptimalValue = String.Empty;
        private string _lightSensorMaxDeviation = String.Empty;
        private string _airTempretureSensorMaxDeviation = String.Empty;
        private string _wetSensorMaxDeviation = String.Empty;
        private string _acidSensorMaxDeviation = String.Empty;
        private string _nutrientSensorMaxDeviation = String.Empty;
        private string _waterTemperatureSensorMaxDeviation = String.Empty;
        public string LightSensorOptimalValue 
        { 
            get
            {
                return _lightSensorOptimalValue;
            } 
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _lightSensorOptimalValue = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string AirTempretureSensorOptimalValue
        {
            get
            {
                return _airTempretureSensorOptimalValue;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _airTempretureSensorOptimalValue = value;
                }
                else 
                {
                    throw new ArgumentException();
                }
            }
        }
        public string WetSensorOptimalValue
        {
            get
            {
                return _wetSensorOptimalValue;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _wetSensorOptimalValue = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string AcidSensorOptimalValue
        {
            get
            {
                return _acidSensorOptimalValue;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _acidSensorOptimalValue = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string NutrientSensorOptimalValue
        {
            get
            {
                return _nutrientSensorOptimalValue;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _nutrientSensorOptimalValue = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string WaterTemperatureSensorOptimalValue
        {
            get
            {
                return _waterTemperatureSensorOptimalValue;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _waterTemperatureSensorOptimalValue = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string LightSensorMaxDeviation
        {
            get
            {
                return _lightSensorMaxDeviation;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _lightSensorMaxDeviation = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string AirTempretureSensorMaxDeviation
        {
            get
            {
                return _airTempretureSensorMaxDeviation;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _airTempretureSensorMaxDeviation = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string WetSensorMaxDeviation
        {
            get
            {
                return _wetSensorMaxDeviation;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _wetSensorMaxDeviation = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string AcidSensorMaxDeviation
        {
            get
            {
                return _acidSensorMaxDeviation;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _acidSensorMaxDeviation = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string NutrientSensorMaxDeviation
        {
            get
            {
                return _nutrientSensorMaxDeviation;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _nutrientSensorMaxDeviation = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string WaterTemperatureSensorMaxDeviation
        {
            get
            {
                return _waterTemperatureSensorMaxDeviation;
            }
            set
            {
                if (Double.Parse(value) > 0)
                {
                    _waterTemperatureSensorMaxDeviation = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Time LightSensorStartTime { get; set; } = new Time(default(int), default(int));
        public Time AirTempretureSensorStartTime { get ; set ; } = new Time(default(int), default(int));
        public Time WetSensorStartHour { get ; set ; } = new Time(default(int), default(int));
        public Time AcidSensorStartHour { get ; set ; } = new Time(default(int), default(int));
        public Time NutrientSensorStartHour { get ; set ; } = new Time(default(int), default(int));
        public Time WaterTemperatureSensorStartHour { get ; set ; } = new Time(default(int), default(int));
        public Time LightSensorEndTime { get ; set ; } = new Time(default(int), default(int));
        public Time AirTempretureSensorEndTime { get ; set ; } = new Time(default(int), default(int));
        public Time WetSensorEndTime { get ; set ; } = new Time(default(int), default(int));
        public Time AcidSensorEndTime { get ; set ; } = new Time(default(int), default(int));
        public Time NutrientSensorEndTime { get ; set ; } = new Time(default(int), default(int));
        public Time WaterTemperatureSensorEndTime { get ; set ; } = new Time(default(int), default(int));

        public DaySchedule GenerateDaySchedule()
        {
            DaySchedule daySchedule = new DaySchedule();

            daySchedule.Day = CurrentDay;

            daySchedule.AirTempretureSensorEndTime = AirTempretureSensorEndTime;
            daySchedule.AirTempretureSensorMaxDeviation = AirTempretureSensorMaxDeviation;
            daySchedule.AirTempretureSensorOptimalValue = AirTempretureSensorOptimalValue;
            daySchedule.AirTempretureSensorStartTime = AirTempretureSensorStartTime;

            daySchedule.AcidSensorEndTime = AcidSensorEndTime;
            daySchedule.AcidSensorMaxDeviation = AcidSensorMaxDeviation;
            daySchedule.AcidSensorOptimalValue = AcidSensorOptimalValue;
            daySchedule.AcidSensorStartHour = AcidSensorStartHour;

            daySchedule.LightSensorEndTime = LightSensorEndTime;
            daySchedule.LightSensorMaxDeviation = LightSensorMaxDeviation;
            daySchedule.LightSensorOptimalValue = LightSensorOptimalValue;
            daySchedule.LightSensorStartTime = LightSensorStartTime;

            daySchedule.NutrientSensorEndTime = NutrientSensorEndTime;
            daySchedule.NutrientSensorMaxDeviation = NutrientSensorMaxDeviation;
            daySchedule.NutrientSensorOptimalValue = NutrientSensorOptimalValue;
            daySchedule.NutrientSensorStartHour = NutrientSensorStartHour;

            daySchedule.WaterTemperatureSensorEndTime = WaterTemperatureSensorEndTime;
            daySchedule.WaterTemperatureSensorMaxDeviation = WaterTemperatureSensorMaxDeviation;
            daySchedule.WaterTemperatureSensorOptimalValue = WaterTemperatureSensorOptimalValue;
            daySchedule.WaterTemperatureSensorStartHour = WaterTemperatureSensorStartHour;

            daySchedule.WetSensorEndTime = WetSensorEndTime;
            daySchedule.WetSensorMaxDeviation = WetSensorMaxDeviation;
            daySchedule.WetSensorOptimalValue = WetSensorOptimalValue;
            daySchedule.WetSensorStartHour = WetSensorStartHour;

            return daySchedule;
        }

        #endregion properties
    }
}
