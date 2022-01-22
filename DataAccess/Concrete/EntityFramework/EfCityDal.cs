using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, JobApplicationContext>, ICityDal
    {
     /*   public List<CityDto> GetAll(Expression<Func<CityDto, bool>> filter = null)
        {
            using (JobApplicationContext context = new JobApplicationContext())
            {
                return filter == null ? context.Set<CityDto>().ToList()
                    : context.Set<CityDto>().Where(filter).ToList();

            }
        } */

        public List<CityDto> GetDetailsByCityId(Expression<Func<City, bool>> filter)
        {
            using (JobApplicationContext context=new JobApplicationContext())
            {
                var result = from c in context.Cities.Where(filter)
                             join b in context.Boroughs on c.CityId equals b.CityId
                             select new CityDto
                             {
                                 CityId = c.CityId,
                                 CityName=c.CityName,
                                 BoroughId=b.BoroughId,
                                 BoroughName=b.BoroughName
                             };
                return result.ToList();
            }
        }

    }
}
