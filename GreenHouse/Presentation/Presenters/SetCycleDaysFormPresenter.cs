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
    public class SetCycleDaysFormPresenter : AbstractPresenter
    {
        public SetCycleDaysFormPresenter(IKernel kernel, IServiceFactory serviceFactory, ISetCycleDaysForm view)
        {
            _kernel = kernel;
            _service = serviceFactory.CreateSetCycleDaysService();
            _view = view;

            (_view as ISetCycleDaysForm).SetSensorsSchedule += () => SetSensorsSchedule();
            (_view as ISetCycleDaysForm).Save += () => Save();
        }

        private void SetSensorsSchedule()
        {
            _kernel.Get<SetSensorsSchedulePresenter>().Run();
        }

        private void Save()
        {
            throw new NotImplementedException();
        }
    }
}
