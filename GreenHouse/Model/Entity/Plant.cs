using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Plant
    {
        public string Name { get; set; }
        public List<DaySchedule> GrowingPlan { get; set; }
    }
}
