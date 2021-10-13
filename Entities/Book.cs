using System;

namespace merchhunters.Common.Entities
{
    public class Book
    {
        public int RecId { get; set; } //модификатор доступа и стринг
        public string Aut { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public string Publ { get; set; }
        public int Yea { get; set; }
        public string Lan { get; set; }
        public RubricType Rubric { get; set; }
        public string Person { get; set; }
        public string Serial { get; set; }
        public string Material { get; set; }
        public string BibLevel { get; set; }
        public Nullable<int> Ager { get; set; }
    }
}
