
using System;
using System.Linq;
using Aram.DA;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using PostgreSQL;
using Aram.IDataAccess;

namespace Aram.DA
{
    public class ProblemDA : BaseDA<Problem> , IProblemDA
    {
        public ProblemDA(IAramContext db) : base(db)
        {
        }
        public IQueryable<Problem> GetProblems() => base.GetAll();
        public new int Delete(int id) => base.Delete(id);
        public new Problem Update(Problem problem, int id) => base.Update(problem, id);
        public new Problem Insert(Problem problem) => base.Insert(problem);
        public new void SaveChanges() => base.SaveChanges();

    }
}