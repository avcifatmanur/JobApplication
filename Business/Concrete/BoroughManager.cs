using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BoroughManager : IBoroughService
    {
        IBoroughDal _boroughDal;

        public BoroughManager(IBoroughDal boroughDal)
        {
            _boroughDal = boroughDal;
        }

        public void Add(Borough borough)
        {
            _boroughDal.Add(borough);
        }

        public void Delete(Borough borough)
        {
            _boroughDal.Delete(borough);
        }
        public void Update(Borough borough)
        {
            _boroughDal.Update(borough);
        }

        public List<Borough> GetAll()
        {
            return _boroughDal.GetAll();
        }

        public Borough GetById(int boroughId)
        {
            return _boroughDal.Get(b => b.BoroughId==boroughId);
        }

        public List<Borough> GetDetailsByCityId(int cityId)
        {
            return _boroughDal.GetDetailsByCityId(b => b.CityId == cityId);
        }
    }
}
