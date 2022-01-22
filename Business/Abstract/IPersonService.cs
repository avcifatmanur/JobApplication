using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
        List<Person> GetAll();
        Person GetById(int personId);
    }
}
