using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface ISetGrowingPlantForm : IView
    {
        event Action Accept;
        event Action AddNewPlant;
        event Action UpdatePlantList;

        string PlantName { get; set; }

        void ShowError(string message);
        void UpdateAvailablePlants(List<string> plants);
    }
}
