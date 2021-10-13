using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merchhunters.DAL.DalContracts
{
    interface ISelector
    {
        Array<Recomendation> Select(Request request);
    }
}
