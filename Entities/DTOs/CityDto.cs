using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CityDto:IDto
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int BoroughId { get; set; }
        public string BoroughName { get; set; }
    }
}
