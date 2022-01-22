using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBoroughService
    {
        void Add(Borough borough);
        void Delete(Borough borough);
        void Update(Borough borough);
        List<Borough> GetAll();
        Borough GetById(int boroughId);
        List<Borough> GetDetailsByCityId(int cityId);
    }
}
