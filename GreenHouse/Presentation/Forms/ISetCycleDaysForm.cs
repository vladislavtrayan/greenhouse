using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface ISetCycleDaysForm : IView
    {
        event Action Save;
        event Action SetSensorsSchedule;

        int SelectedItemId { get; }
    }
}
