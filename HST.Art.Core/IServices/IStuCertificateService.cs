﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HST.Art.Core
{
    public interface IStuCertificateService : IBaseService
    {
        List<StuCertificate> GetPage(FilterEntityModel filterModel, out int totalNum);
        List<StuCertificate> GetAll(FilterEntityModel filterModel);
        StuCertificate Get(int id);
        StuCertificate GetByNumber(string number);
        bool Update(StuCertificate StuInfo);
        bool Add(StuCertificate StuInfo);
    }
}
