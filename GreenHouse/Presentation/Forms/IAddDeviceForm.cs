using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface IAddDeviceForm : IView
    {
        event Action AddDevice;
        event Action UpdateListOfDevice;

        event Action ShowOnlyDevices;
        event Action ShowOnlySensors;
        event Action ShowOnlyPassiveSensors;
        event Action ShowOnlyActiveSensors;

        int SelectedDeviceId { get;}
        void UpdateDeviceList(List<UIElement> uIElements);
    }
}
