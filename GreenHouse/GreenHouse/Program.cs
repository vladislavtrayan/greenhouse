using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Presentation.Forms;
using Presentation.Presenter;
using Ninject.Modules;
using Ninject.Extensions.Factory;
using Model.Service;
using Model;

namespace GreenHouse
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<IServiceFactory>().ToFactory();

            kernel.Bind<IAddNewPlantForm>().To<AddNewPlantForm>();
            kernel.Bind<IAddDeviceForm>().To<AddDeviceForm>();
            kernel.Bind<ISetCycleDaysForm>().To<SetCycleDaysForm>();
            kernel.Bind<ISetGrowingPlantForm>().To<SetGrowingPlantForm>();
            kernel.Bind<ISetSensorsSchedule>().To<SetSensorsShedule>();
            kernel.Bind<IMainForm>().To<MainForm>();


            kernel.Bind<IMainFormService>().To<MainFormService>().InSingletonScope();
            kernel.Bind<ISetCycleDaysService>().To<SetCycleDaysService>().InSingletonScope();
            kernel.Bind<ISetSensorsSchduleService>().To<SetSensorsScheduleService>().InSingletonScope();
            kernel.Bind<IAddNewDeviceService>().To<AddNewDeviceService>().InSingletonScope();
            kernel.Bind<ISetGrowingPlantService>().To<SetGrowingPlantService>().InSingletonScope();
            kernel.Bind<IAddNewPlantService>().To<AddNewPlantService>().InSingletonScope();

            kernel.Bind<AddNewPlantFormPresenter>().ToSelf();
            kernel.Bind<AddDeviceFormPresenter>().ToSelf();
            kernel.Bind<SetCycleDaysFormPresenter>().ToSelf();
            kernel.Bind<SetGrowingPlantFormPresenter>().ToSelf();
            kernel.Bind<SetSensorsSchedulePresenter>().ToSelf();
            kernel.Bind<MainFormPresenter>().ToSelf();




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<MainFormPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
