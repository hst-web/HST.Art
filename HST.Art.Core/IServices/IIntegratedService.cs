using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HST.Art.Core
{
    public interface IIntegratedService
    {
        Setting GetSetting(SettingType setType);
        bool UpdateSetting(Setting setInfo);
        bool DeleteSetting(int id);
    }
}
