using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface ISetCycleDaysService : IService
    {
        event Action NewPlantWasAdded;
        int SelectedDay { get; set; }
        int AmountOfDays { get; set; }
        string PlantName { get; set; }
        List<DaySchedule> DaySchedules { get; }
        void SetSensorsScheduleService(DaySchedule daySchedule);
        void SaveSchedule();
    }
}
