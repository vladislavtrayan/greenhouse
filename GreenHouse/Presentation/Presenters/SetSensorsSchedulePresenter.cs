using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entity;
using Model.Service;
using Ninject;
using Presentation.Forms;

namespace Presentation.Presenter
{
    public class SetSensorsSchedulePresenter : AbstractPresenter<ISetSensorsSchedule>
    {
        public SetSensorsSchedulePresenter(IKernel kernel, IServiceFactory serviceFactory, ISetSensorsSchedule view) : base(kernel, serviceFactory, view)
        {
            _view.SaveData += () => SaveData();
            _view.FieldUpdate += () => FieldUpdated();

            _view.SetCurrentDay(_serviceFactory.CreateSetCycleDaysService().SelectedDay);
            _serviceFactory.CreateSetSensorsScheduleService().CurrentDay =
                _serviceFactory.CreateSetCycleDaysService().SelectedDay;

        }

        private void SaveData()
        {
            DaySchedule daySchedule = _serviceFactory.CreateSetSensorsScheduleService().GenerateDaySchedule();

            _serviceFactory.CreateSetCycleDaysService().SetSensorsScheduleService(daySchedule);
        }

        private void FieldUpdated()
        {
            try
            {
                _serviceFactory.CreateSetSensorsScheduleService().AcidSensorMaxDeviation = _view.AcidSensorMaxDeviation;
                _serviceFactory.CreateSetSensorsScheduleService().AcidSensorEndTime = _view.AcidSensorEndTime;
                _serviceFactory.CreateSetSensorsScheduleService().AcidSensorOptimalValue = _view.AcidSensorOptimalValue;
                _serviceFactory.CreateSetSensorsScheduleService().AcidSensorStartHour = _view.AcidSensorStartHour;

                _serviceFactory.CreateSetSensorsScheduleService().AirTempretureSensorEndTime = _view.AirTempretureSensorEndTime;
                _serviceFactory.CreateSetSensorsScheduleService().AirTempretureSensorMaxDeviation = _view.AirTempretureSensorMaxDeviation;
                _serviceFactory.CreateSetSensorsScheduleService().AirTempretureSensorOptimalValue = _view.AirTempretureSensorOptimalValue;
                _serviceFactory.CreateSetSensorsScheduleService().AirTempretureSensorStartTime = _view.AirTempretureSensorStartTime;

                _serviceFactory.CreateSetSensorsScheduleService().LightSensorEndTime = _view.LightSensorEndTime;
                _serviceFactory.CreateSetSensorsScheduleService().LightSensorMaxDeviation = _view.LightSensorMaxDeviation;
                _serviceFactory.CreateSetSensorsScheduleService().LightSensorOptimalValue = _view.LightSensorOptimalValue;
                _serviceFactory.CreateSetSensorsScheduleService().LightSensorStartTime = _view.LightSensorStartTime;

                _serviceFactory.CreateSetSensorsScheduleService().WetSensorEndTime = _view.WetSensorEndTime;
                _serviceFactory.CreateSetSensorsScheduleService().WetSensorMaxDeviation = _view.WetSensorMaxDeviation;
                _serviceFactory.CreateSetSensorsScheduleService().WetSensorOptimalValue = _view.WetSensorOptimalValue;
                _serviceFactory.CreateSetSensorsScheduleService().WetSensorStartHour = _view.WetSensorStartHour;

                _serviceFactory.CreateSetSensorsScheduleService().WaterTemperatureSensorEndTime = _view.WaterTemperatureSensorEndTime;
                _serviceFactory.CreateSetSensorsScheduleService().WaterTemperatureSensorMaxDeviation = _view.WaterTemperatureSensorMaxDeviation;
                _serviceFactory.CreateSetSensorsScheduleService().WaterTemperatureSensorOptimalValue = _view.WaterTemperatureSensorOptimalValue;
                _serviceFactory.CreateSetSensorsScheduleService().WaterTemperatureSensorStartHour = _view.WaterTemperatureSensorStartHour;

                _serviceFactory.CreateSetSensorsScheduleService().NutrientSensorEndTime = _view.NutrientSensorEndTime;
                _serviceFactory.CreateSetSensorsScheduleService().NutrientSensorMaxDeviation = _view.NutrientSensorMaxDeviation;
                _serviceFactory.CreateSetSensorsScheduleService().NutrientSensorOptimalValue = _view.NutrientSensorOptimalValue;
                _serviceFactory.CreateSetSensorsScheduleService().NutrientSensorStartHour = _view.NutrientSensorStartHour;
            }catch(Exception e)
            {
                _view.ShowError("Одно из полей заполнено неверно!");
            }
        }
    }
}
