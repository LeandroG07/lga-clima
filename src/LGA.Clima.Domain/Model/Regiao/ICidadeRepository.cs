
using LGA.Clima.Domain.Model.Abstraction;

namespace LGA.Clima.Domain.Model.Regiao
{
    public interface ICidadeRepository<T, TKey> : IRepository<T, TKey> where T : Entity<TKey>
    {
    }
}
