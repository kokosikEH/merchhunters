using merchhunters.BLL.BLLContracts;
using merchhunters.Common.Entities;
using merchhunters.DAL.DalContracts;
using System;

namespace BLL
{
    public class CatalogLogic : ICatalogLogic
    {
        public CatalogLogic(ISelector selector)
        {
            _dataSelector = selector;
        }

        ISelector _dataSelector;

        //DocumentDao _documentDao;

        public Response GetRecomendation(Request request, RecomendationType recomendationType = RecomendationType.Basic)
        {
            throw new NotImplementedException();
        }

        Recomendation[] GetData(Request request) { return null; }
        Recomendation[] SelectRecomendate(Request request, RecomendationType recomendationType) { return null; }
        //ValidationResult Validate(Request request) { return null; }
    }
}
