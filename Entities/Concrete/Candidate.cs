using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Candidate:IEntity
    {
        public int CandidateId { get; set; }
        public int PersonId { get; set; }
        public DateTime ? DateOfApplication { get; set; }
        public int CityId { get; set; }
        public bool NotTravelDisability { get; set; }
        public string WorkplaceName { get; set; }
        public string Situation { get; set; }
        public string Description { get; set; }


    }
}
