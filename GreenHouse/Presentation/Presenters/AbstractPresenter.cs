using Model;
using Ninject;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenter
{
    public abstract class AbstractPresenter
    {
        protected IKernel _kernel { get; set; }
        protected IService _service { get; set; }
        protected IView _view { get; set; }

        public void Run()
        {
            _view.Show();
        }
    }
}
