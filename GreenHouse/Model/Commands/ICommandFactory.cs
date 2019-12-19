using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Commands
{
    public interface ICommandFactory
    {
        AcidRegulatorCommand CreateAcidRegulatorCommand();
        AirTemperatureHeaterCommand CreateAirTemperatureHeaterCommand();
        WaterTemperatureHeaterCommand CreateWaterTemperatureHeaterCommand();
        NutrientRegulatorCommand CreateNutrientRegulatorCommand();
    }
}
