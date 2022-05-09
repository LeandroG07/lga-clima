using LGA.Clima.Domain.Models.Abstractions;

namespace LGA.Clima.Data.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        public TEntity Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity model)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity model)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity model)
        {
            throw new NotImplementedException();
        }

    }
}
