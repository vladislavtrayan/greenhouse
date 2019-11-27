using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface IAddNewPlantForm : IView
    {
        event Action Next;

        string PlantName { get; set; }
        string NumberOfDaysInCycle { get; set; }

        void ShowError(string message);
    }
}
