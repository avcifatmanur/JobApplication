using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICandidateService
    {
        void Add(Candidate candidate);
        void Delete(Candidate candidate);
        void Update(Candidate candidate);
        List<Candidate> GetAll();
        Candidate GetById(int candidateId);
    }
}
