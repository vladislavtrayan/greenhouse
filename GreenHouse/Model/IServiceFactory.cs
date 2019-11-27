using Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IServiceFactory
    {
        IMainFormService CreateMainFormService();
        ISetCycleDaysService CreateSetCycleDaysService();
        ISetSensorsSchduleService CreateSetSensorsScheduleService();
        ISetGrowingPlantService CreateSetGrowingPlantService();
        IAddNewPlantService CreateAddNewPlantService();
        IAddNewDeviceService CreateAddNewDeviceService();
    }
}
