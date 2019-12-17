using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IDeviceFactory
    {
        IDevice CreateDevice(DeviceType deviceType);
        IDevice CreateDevice(DeviceType deviceType,int index);
    }
}
