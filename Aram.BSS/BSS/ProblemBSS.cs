using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IBSS;
using Aram.IDataAccess;
using System.Collections.Generic;
using System;

namespace Aram.BSS
{


    public class ProblemBSS : IProblemBSS
    {
        IProblemDA _problemDA;
        public ProblemBSS(IProblemDA problemDA)
        {
            _problemDA = problemDA;
        }
        private IQueryable<Problem> GetProblems() => _problemDA.GetProblems();
        public IQueryable<Problem> GetAll() => GetProblems();
        public IQueryable<Problem> GetById(int id) => GetProblems().Where(x => x.problemID == id);
        public IQueryable<Problem> GetByName(string Name) => GetProblems().Where(x => x.name.Contains(Name));
        public int Delete(int id) => _problemDA.Delete(id);
        public Problem Update(Problem problem, int id) => _problemDA.Update(problem, id);
        public Problem Insert(Problem problem)
        {
            return _problemDA.Insert(problem);
        }
        public void SaveChanges() => _problemDA.SaveChanges();

    }
}