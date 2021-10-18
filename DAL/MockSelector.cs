using merchhunters.Common.Entities;
using merchhunters.DAL.DalContracts;
using System;

namespace merchhunters.DAL.DAL
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
