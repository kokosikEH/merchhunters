using merchhunters.BLL.BLLContracts;
using merchhunters.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace merchhunters.Models
{
    public class CatalogModel
    {
        ICatalogLogic _logic;

        public CatalogModel(ICatalogLogic catalogLogic)
        {
            _logic = catalogLogic;
            
        }

        public Response GetResponse(Request request)
        {
            return _logic.GetRecomendation(request);
        }
    }
}
