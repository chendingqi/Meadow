using Data.IRepository;
using Domain.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class Service<T> : IService<T> where T : BaseEntity, new()
    {

        protected readonly IRepository<T> repository;

        public Service(IRepository<T> _repository)
        {
            this.repository = _repository;
        }

        public virtual async Task<T> Create(T entidate)
        {
            return await repository.Create(entidate);
        }

        public virtual async Task Delete(Guid id)
        {
            await repository.Delete(id);
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> filter)
        {
            return repository.Find(filter);
        }

        public virtual async Task<T> Get(Guid id)
        {
            return await repository.Get(id);
        }

        public virtual async Task<IEnumerable<T>> List()
        {
            return await repository.List();
        }

        public virtual IQueryable<T> Paginar(IQueryable<T> query, int? pagina = null, int? qtde = null)
        {
            return repository.Paginar(query, pagina, qtde);
        }

        public virtual async Task<T> Update(T entidate)
        {
            return await repository.Update(entidate);
        }
    }
}
