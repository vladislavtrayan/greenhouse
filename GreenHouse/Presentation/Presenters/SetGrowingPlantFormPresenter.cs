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
    public class SetGrowingPlantFormPresenter : AbstractPresenter
    {
        public SetGrowingPlantFormPresenter(IKernel kernel, IServiceFactory serviceFactory, ISetGrowingPlantForm view)
        {
            _kernel = kernel;
            _service = serviceFactory.CreateSetGrowingPlantService();
            _view = view;
            (_view as ISetGrowingPlantForm).Accept += () => Accept();
            (_view as ISetGrowingPlantForm).AddNewPlant += () => AddNewPlant();
        }

        private void Accept()
        {
            var service = _service as ISetGrowingPlantService;
            var view = _view as ISetGrowingPlantForm;
            try
            {
                // Will be added with service logic
                throw new NotImplementedException();
                service.GrowingPlantName = view.PlantName;
                _view.Close();
            }
            catch
            {
                view.ShowError("Введено не верное значение");
            }
        }
        private void AddNewPlant()
        {
            _kernel.Get<AddNewPlantFormPresenter>().Run();
            _view.Close();
        }

    }
}
