using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ninject;
using Presentation.Forms;

namespace Presentation.Presenter
{
    public class AddDeviceFormPresenter : AbstractPresenter
    {
        public AddDeviceFormPresenter(IKernel kernel,IServiceFactory  serviceFactory, IAddDeviceForm view)
        {
            _kernel = kernel;
            _service = serviceFactory.CreateAddNewDeviceService();
            _view = view;

            (_view as IAddDeviceForm).AddDevice += () => AddDevice();
        }

        public void AddDevice()
        {
            throw new NotImplementedException();
        }
    }
}
