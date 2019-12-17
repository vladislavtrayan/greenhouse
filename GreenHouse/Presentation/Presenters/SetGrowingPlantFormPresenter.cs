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
    public class SetGrowingPlantFormPresenter : AbstractPresenter<ISetGrowingPlantForm>
    {
        public SetGrowingPlantFormPresenter(IKernel kernel, IServiceFactory serviceFactory, ISetGrowingPlantForm view) : base(kernel,serviceFactory,view)
        {
            _view.Accept += () => Accept();
            _view.AddNewPlant += () => AddNewPlant();
            _view.UpdatePlantList += () => UpdatePlantList(); 

            //_serviceFactory.CreateSetCycleDaysService().NewPlantWasAdded += () => UpdatePlantList();
        }

        private void Accept()
        {
            var service = _serviceFactory.CreateSetGrowingPlantService();
            try
            {
                service.GrowingPlantName = _view.PlantName;
                _serviceFactory.CreateMainFormService().GrowingPlant = service.GrowingPlant;
                _view.Close();
            }
            catch
            {
                _view.ShowError("Введено не верное значение");
            }
        }
        private void AddNewPlant()
        {
            _kernel.Get<AddNewPlantFormPresenter>().Run();
            _view.Close();
        }

        private void UpdatePlantList()
        {
            _view.UpdateAvailablePlants(_serviceFactory.CreateSetGrowingPlantService().GetAllPlantTitles());
        }
    }
}
