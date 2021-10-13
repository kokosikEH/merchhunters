using merchhunters.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merchhunters.DAL.DalContracts
{
    interface ISelector
    {
        Recomendation[] Select(Request request);
    }
}
