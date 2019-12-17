using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface ISetGrowingPlantService : IService
    {
        string GrowingPlantName { get; set; }
        Plant GrowingPlant { get; set; }
        List<string> GetAllPlantTitles();
    }
}
