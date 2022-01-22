using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Delete(City city)
        {
            _cityDal.Delete(city);
        }
        public void Update(City city)
        {
            _cityDal.Update(city);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public City GetById(int cityId)
        {
            return _cityDal.Get(c => c.CityId == cityId);
        }

        public List<CityDto> GetDetailsByCityId(int cityId)
        {
            return _cityDal.GetDetailsByCityId(c => c.CityId == cityId);
        }
    }
}
