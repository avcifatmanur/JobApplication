using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICityService
    {
        void Add(City city);
        void Delete(City city);
        void Update(City city);
        City GetById(int cityId);
        List<City> GetAll();
        List<CityDto> GetDetailsByCityId(int cityId);

    }
}
