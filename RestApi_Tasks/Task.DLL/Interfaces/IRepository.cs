using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.DAL.Interfaces
{
    public interface IRepository<Model> where Model : class
    {
        Task<Model> Get(Expression<Func<Model, bool>> filter);
        Task<bool> Create(Model model);
        Task<bool> Update(Model model);
        Task<bool> Delete(Model model);
        Task<IQueryable<Model>> Query(Expression<Func<Model, bool>> filter = null);
    }
}
