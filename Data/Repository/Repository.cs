using Data.Context;
using Data.IRepository;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected readonly MeadowContext context;

        public Repository(MeadowContext _context)
        {
            this.context = _context;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        protected async Task Salvar()
        {
            await context.SaveChangesAsync();
        }
        public virtual async Task<T> Create(T entidate)
        {
            context.Entry(entidate).State = EntityState.Added;
            await Salvar();
            return entidate;
        }

        public virtual async Task Delete(Guid id)
        {
            var entidade = context.Set<T>().Find(id);
            context.Entry(entidade).State = EntityState.Deleted;
            await Salvar();
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> filter)
        {
            var query = context.Set<T>().Where(filter);
            return query;
        }

        public virtual async Task<T> Get(Guid id)
        {
            IQueryable<T> query = context.Set<T>();
            var entidate = await query.SingleOrDefaultAsync(x => x.Id == id);
            if (entidate is null)
            {
                throw new NotImplementedException();
            }
            return entidate;
        }

        public virtual async Task<IEnumerable<T>> List()
        {
            return await context.Set<T>().ToListAsync();
        }

        public virtual IQueryable<T> Paginar(IQueryable<T> query, int? pagina = null, int? qtde = null)
        {
            if (pagina != null && qtde != null)
            {
                if (pagina == 0)
                {
                    pagina = 1;
                }
                query = query.Skip(((int)pagina - 1) * (int)qtde).Take((int)qtde);
            }
            return query;
        }

        public virtual async Task<T> Update(T entidate)
        {
            context.Entry(entidate).State = EntityState.Unchanged;
            await Salvar();
            return entidate;
        }
    }
}
