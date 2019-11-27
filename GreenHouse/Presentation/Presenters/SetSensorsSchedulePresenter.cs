using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Service;
using Ninject;
using Presentation.Forms;

namespace Presentation.Presenter
{
    public class SetSensorsSchedulePresenter : AbstractPresenter
    {
        public SetSensorsSchedulePresenter(IKernel kernel, IServiceFactory serviceFactory, ISetSensorsSchedule view)
        {
            _kernel = kernel;
            _service = serviceFactory.CreateSetSensorsScheduleService();
            _view = view;
        }
    }
}
