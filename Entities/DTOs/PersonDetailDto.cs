using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonDetailDto:IDto
    {
        public int PersonId { get; set; }
        public string FirstName_LastName { get; set; }
        public string CityName { get; set; }
        public string BoroughName { get; set; }
        public string Gender { get; set; }
        public DateTime ? DateOfBirth { get; set; }
        public string Description { get; set; }

    }
}
