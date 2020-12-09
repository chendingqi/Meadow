using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IService<T> where T : BaseEntity, new()
    {
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> Get(Guid id);
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entidate"></param>
        /// <returns></returns>
        Task<T> Create(T entidate);
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(Guid id);
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entidate"></param>
        /// <returns></returns>
        Task<T> Update(T entidate);
        /// <summary>
        /// lambda表达式查找数据
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IQueryable<T> Find(Expression<Func<T, bool>> filter);
        /// <summary>
        /// 获取全部实体
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> List();
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="query"></param>
        /// <param name="pagina">第几页</param>
        /// <param name="qtde">每页多少条数据</param>
        /// <returns></returns>
        IQueryable<T> Paginar(IQueryable<T> query, int? pagina = null, int? qtde = null);
    }
}
