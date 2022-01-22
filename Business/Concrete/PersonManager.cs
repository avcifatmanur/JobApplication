using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }
        public void Update(Person person)
        {
            _personDal.Update(person);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public Person GetById(int personId)
        {
            return _personDal.Get(p=>p.PersonId==personId);
        }
    }
}
