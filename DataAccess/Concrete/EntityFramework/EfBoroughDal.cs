using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBoroughDal : EfEntityRepositoryBase<Borough, JobApplicationContext>, IBoroughDal
    {
        public List<Borough> GetDetailsByCityId(Expression<Func<Borough, bool>> filter)
        {
            using (JobApplicationContext context = new JobApplicationContext())
            {
                var result = from b in context.Boroughs.Where(filter)
                             join c in context.Cities on b.CityId equals c.CityId
                             
                             select new Borough
                             {
                                 CityId = c.CityId,
                                 BoroughId = b.BoroughId,
                                 BoroughName = b.BoroughName
                             };
                return result.ToList();

            }
        }
    }
}
