using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class SetGrowingPlantService : ISetGrowingPlantService
    {
        private string _growingPlantName;
        public string GrowingPlantName { get => _growingPlantName; set { if (value.Length > 0) _growingPlantName = value; else throw new ArgumentException($"{value} is empty."); } }
    }
}
