using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int PersonId { get; set; }
        public string FirstName_LastName { get; set; }
        public int CityId { get; set; }
        public int BoroughId { get; set; }
        public string Gender { get; set; }
        public DateTime ? DateOfBirth { get; set; }
        public string Description { get; set; }
    }
}
