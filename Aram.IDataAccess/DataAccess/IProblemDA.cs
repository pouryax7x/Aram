
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace Aram.IDataAccess
{


    public interface IProblemDA
    {
        IQueryable<Problem> GetProblems();
        int Delete(int id);
        Problem Update(Problem problem, int id);
        Problem Insert(Problem problem);
        void SaveChanges();

    }
}