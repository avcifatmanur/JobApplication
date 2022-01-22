using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICityDal:IEntityRepository<City>
    {
       // List<CityDto> GetAll(Expression<Func<CityDto, bool>> filter = null);
        List<CityDto> GetDetailsByCityId(Expression<Func<City, bool>> filter);
    }
}
