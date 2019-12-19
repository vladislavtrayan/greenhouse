using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public interface ICommand
    {
        void Run(Position position,double value);
        void Stop(Position position);
    }
}
