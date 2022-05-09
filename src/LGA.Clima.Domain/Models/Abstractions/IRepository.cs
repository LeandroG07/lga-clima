
namespace LGA.Clima.Domain.Models.Abstractions
{
    public interface IRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {

        TEntity Get(TKey key);

        IEnumerable<TEntity> Get();

        void Insert(TEntity model);

        void Update(TEntity model);

        void Delete(TEntity model);

    }
}
