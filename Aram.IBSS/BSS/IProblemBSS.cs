
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using System.Collections.Generic;

namespace Aram.IBSS
{


    public interface IProblemBSS
    {
        IQueryable<Problem> GetAll();
        IQueryable<Problem> GetById(int id);
        IQueryable<Problem> GetByName(string Name);
        int Delete(int id);
        Problem Update(Problem problem, int id);
        Problem Insert(Problem problem);
        void SaveChanges();

    }
}