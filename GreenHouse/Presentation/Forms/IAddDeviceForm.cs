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
        int SelectedDeviceId { get;}
    }
}
