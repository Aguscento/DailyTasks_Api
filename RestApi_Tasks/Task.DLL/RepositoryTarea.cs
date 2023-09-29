using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Interfaces;
using Task.Models;

namespace Task.DAL
{
    public class RepositoryTarea : IRepository<Tarea>
    {
        private readonly DbtaskContext _dbtaskContext;
        public RepositoryTarea(DbtaskContext dbtaskContext)
        {
            _dbtaskContext = dbtaskContext;
        }
        public async Task<Tarea> Get(Expression<Func<Tarea, bool>> filter)
        {
            try
            {
                Tarea tarea = await _dbtaskContext.Set<Tarea>().FirstOrDefaultAsync(filter);
                return tarea;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<bool> Update(Tarea model)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> Create(Tarea model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Tarea model)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Tarea>> Query(Expression<Func<Tarea, bool>> filter = null)
        {
            try
            {
                IQueryable<Tarea> query = _dbtaskContext.Tareas;
                if (filter != null)
                {
                    query = query.Where(filter);

                }
                return query;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
