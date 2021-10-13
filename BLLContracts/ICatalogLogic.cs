using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using merchhunters.Common.Entities;

namespace merchhunters.BLL.BLLContracts
{
    public interface ICatalogLogic
    {
        Response GetRecomendation(Request request, RecomendationType recomendationType = RecomendationType.Basic);
    }
}
