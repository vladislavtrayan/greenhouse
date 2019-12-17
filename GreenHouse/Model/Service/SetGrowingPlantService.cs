using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class SetGrowingPlantService : ISetGrowingPlantService
    {
        private List<Plant> Plants { get; set; }
        private string _growingPlantName;
        public string GrowingPlantName { get => _growingPlantName; 
            set 
            {
                Plants = _repository.GetAll();
                if (Plants.Select(p => p.Name).Contains(value))
                {
                    _growingPlantName = value;
                    GrowingPlant = Plants.Where(p => p.Name == _growingPlantName).FirstOrDefault();
                }
                else
                    throw new ArgumentException($"{value} is invalid."); 
            } 
        }

        public Plant GrowingPlant { get ; set ; }

        private IRepository<Plant> _repository;
        private readonly ITimer _timer;
        public SetGrowingPlantService(ITimer timer,IRepository<Plant> repository)
        {
            _repository = repository;
            //_timer = timer;
            //_timer.Interval = 110;
            //_timer.Tick += TimerTick;
            //_timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
        }

        public List<string> GetAllPlantTitles()
        {
            return _repository.GetAll().Select(p => p.Name).ToList();
        }
    }
}
