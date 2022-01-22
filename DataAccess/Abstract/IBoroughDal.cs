using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBoroughDal : IEntityRepository<Borough>
    {
        List<Borough> GetDetailsByCityId(Expression<Func<Borough, bool>> filter);
    }
}
