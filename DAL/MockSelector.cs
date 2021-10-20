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
            Book book1 = new Book();
            Book book2 = new Book();
            book1.Title = "Harry Potter";
            book2.Title = "Parry Hotter";
            Recomendation rec1 = new Recomendation();
            Recomendation rec2 = new Recomendation();
            rec1.Book = book1;
            rec2.Book = book2;
            Recomendation[] recs = { rec1, rec2 };
            return recs;
        }

        void GetData()
        {

        }
        protected void GenerateQuery()
        {

        }
    }
}
