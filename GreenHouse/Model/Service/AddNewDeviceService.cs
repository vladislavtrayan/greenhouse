using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class AddNewDeviceService : IAddNewDeviceService
    {
        private IRepository<UIElement> _repository;
        private DeviceFactory DeviceFactory { get; set; }
        public AddNewDeviceService(IRepository<UIElement> repository)
        {
            _repository = repository;
        }

        public List<UIElement> GetUIElements()
        {
            return _repository.GetAll();
        }
    }
}
