using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entity;
using Model.Service;
using Ninject;
using Presentation.Forms;

namespace Presentation.Presenter
{
    public class AddDeviceFormPresenter : AbstractPresenter<IAddDeviceForm>
    {
        public AddDeviceFormPresenter(IKernel kernel,IServiceFactory  serviceFactory, IAddDeviceForm view) : base(kernel, serviceFactory, view)
        {
            _view.AddDevice += () => AddDevice();
            _view.UpdateListOfDevice += () => UpdateDeviceList();
        }

        public void AddDevice()
        {
            var service = _serviceFactory.CreateMainFormService();
            var uIElement = _serviceFactory.CreateAddNewDeviceService().GetUIElements()[_view.SelectedDeviceId];

            service.AddNewElement(uIElement);
        }

        public void UpdateDeviceList()
        {
            _view.UpdateDeviceList(_serviceFactory.CreateAddNewDeviceService().GetUIElements());
        }
    }
}
