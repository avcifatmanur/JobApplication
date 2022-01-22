using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CandidateDetailDto:IDto
    {
        public int CandidateId { get; set; }
        public string FirstName_LastName { get; set; }
        public string CityName { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public bool NotTravelDisability { get; set; }
        public string WorkplaceName { get; set; }
        public string Situation { get; set; }
        public string Description { get; set; }
    }
}
