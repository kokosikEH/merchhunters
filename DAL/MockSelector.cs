using merchhunters.Common.Entities;
using merchhunters.DAL.DalContracts;
using System;

namespace DAL
{
    public class MockSelector : ISelector
    {
        public MockSelector()
        {
        }

        public Recomendation[] Select(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
