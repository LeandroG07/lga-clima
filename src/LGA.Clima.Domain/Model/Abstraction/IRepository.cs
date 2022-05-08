
namespace LGA.Clima.Domain.Model.Abstraction
{
    public interface IRepository<T, TKey> where T : Entity<TKey>
    {

        T Get(TKey key);

        IEnumerable<T> Get();

        void Insert(T model);

        void Update(T model);

        void Delete(T model);

    }
}
