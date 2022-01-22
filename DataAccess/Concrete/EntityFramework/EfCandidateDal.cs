using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCandidateDal : EfEntityRepositoryBase<Candidate, JobApplicationContext>, ICandidateDal
    {
        public List<CandidateDetailDto> GetPersonDetails()
        {
            using (JobApplicationContext context = new JobApplicationContext())
            {
                var result = from c in context.Candidates
                             join city in context.Cities on c.CityId equals city.CityId
                             join p in context.People on c.PersonId equals p.PersonId
                             select new CandidateDetailDto
                             {
                                 CandidateId=c.CandidateId,
                                 FirstName_LastName=p.FirstName_LastName,
                                 DateOfApplication=c.DateOfApplication,
                                 CityName=city.CityName,
                                 NotTravelDisability=c.NotTravelDisability,
                                 WorkplaceName=c.WorkplaceName,
                                 Situation=c.Situation,
                                 Description=c.Description
                             };
                return result.ToList();
            }
        }
    }
}
