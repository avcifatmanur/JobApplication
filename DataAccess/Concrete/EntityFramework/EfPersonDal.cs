using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, JobApplicationContext>, IPersonDal
    {
        public List<PersonDetailDto> GetPersonDetails()
        {
            using (JobApplicationContext context = new JobApplicationContext())
            {
                var result = from p in context.People
                             join b in context.Boroughs on p.BoroughId equals b.BoroughId
                             join c in context.Cities on p.CityId equals c.CityId
                             select new PersonDetailDto
                             {
                                 PersonId=p.PersonId,
                                 FirstName_LastName=p.FirstName_LastName,
                                 CityName=c.CityName,
                                 BoroughName=b.BoroughName,
                                 Gender=p.Gender,
                                 DateOfBirth=p.DateOfBirth,
                                 Description=p.Description
                             };
                return result.ToList();
            }
        }
    }
}
