using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CandidateManager : ICandidateService
    {
        ICandidateDal _candidateDal;

        public CandidateManager(ICandidateDal candidateDal)
        {
            _candidateDal = candidateDal;
        }

        public void Add(Candidate candidate)
        {
            _candidateDal.Add(candidate);
        }

        public void Delete(Candidate candidate)
        {
            _candidateDal.Delete(candidate);
        }
        public void Update(Candidate candidate)
        {
            _candidateDal.Update(candidate);
        }

        public List<Candidate> GetAll()
        {
            return _candidateDal.GetAll();
        }

        public Candidate GetById(int candidateId)
        {
            return _candidateDal.Get(c => c.CandidateId == candidateId);
        }

    }
}
