using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HST.Art.Core
{
    public interface IMemberUnitService : IBaseService
    {
        List<MemberUnit> GetPage(FilterEntityModel filterModel, out int totalNum);
        List<MemberUnit> GetAll(FilterEntityModel filterModel);
        MemberUnit Get(int id);
        MemberUnit GetByNumber(string number);
        bool Update(MemberUnit MemberUnitInfo);
        bool Add(MemberUnit MemberUnitInfo);
    }
}
