using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint - kısıtlama - referans tip olmalı ve de IEntity veya IEntity implemente eden bir nesne olabilir
    // new() şartı ekleyince de IEntity interfacesi hariç diğer newlenebilen classlar eklenebilecek
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
