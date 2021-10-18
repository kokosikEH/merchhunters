using merchhunters.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace merchhunters.Models
{
    public class RecomendationTypeViewModel
    {
        public RecomendationTypeViewModel()
        {
            RecomendationTypes = new List<(string Name, RecomendationType Type)>() 
            {
                ("Обычная", RecomendationType.Basic),
                ("По жанру", RecomendationType.Rubric),
                ("По автору", RecomendationType.Author),
                ("По серии", RecomendationType.Series),
            };
        }

        public int RecomendationTypeId { get; set; }
        public List<(string Name, RecomendationType Type)> RecomendationTypes { get; set; }
    }
}
