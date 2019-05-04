using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HST.Art.Core
{
    public interface IRotationChartService : IBaseService
    {
        List<RotationChart> GetAll(RotationType rotationType);
        RotationChart Get(int id);
        bool Update(List<RotationChart> rotations);
        bool Update(RotationChart rotationInfo);
        bool Add(RotationChart rotationInfo);
    }
}
