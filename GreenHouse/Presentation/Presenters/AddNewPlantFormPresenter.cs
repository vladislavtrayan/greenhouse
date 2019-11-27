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
    public class AddNewPlantFormPresenter : AbstractPresenter
    {
        public AddNewPlantFormPresenter(IKernel kernel, IServiceFactory serviceFactory, IAddNewPlantForm view)
        {
            _kernel = kernel;
            _service = serviceFactory.CreateAddNewPlantService();
            _view = view;

            (_view as IAddNewPlantForm).Next += () => Next();
        }

        private void Next()
        {
            var view = _view as IAddNewPlantForm;
            var service = _service as IAddNewPlantService;

            try
            {
                int.TryParse(view.NumberOfDaysInCycle, out int numberOfDaysInCycle);
                service.NumberOfDaysInCycle = numberOfDaysInCycle;
                service.PlantName = view.PlantName;
                _kernel.Get<SetCycleDaysFormPresenter>().Run();
                _view.Close();
            }
            catch
            {
                view.ShowError("Введено некорректное значение");
            }
        }
    }
}
