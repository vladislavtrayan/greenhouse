using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Service;
using Ninject;
using Presentation.Forms;
using Presentation.Presenter;

namespace Presentation
{
    public class MainFormPresenter : AbstractPresenter
    {
        public MainFormPresenter(IKernel kernel, IServiceFactory serviceFactory, IMainForm view)
        {
            _kernel = kernel;
            _service = serviceFactory.CreateMainFormService();
            _view = view;

            (_view as IMainForm).AddNewDevice += () => AddNewDevice();
            (_view as IMainForm).SetCurrentGrowingPlant += () => SetCurrentGrowingPlant();
            (_view as IMainForm).StartCycle += () => StartCycle();
        }

        private void AddNewDevice()
        {
            _kernel.Get<AddDeviceFormPresenter>().Run();
        }

        private void SetCurrentGrowingPlant()
        {
            _kernel.Get<SetGrowingPlantFormPresenter>().Run();
        }

        private void StartCycle()
        {
            throw new NotImplementedException();
        }
    }
}
