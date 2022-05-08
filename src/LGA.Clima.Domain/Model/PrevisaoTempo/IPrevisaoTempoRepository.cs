using LGA.Clima.Domain.Model.Abstraction;

namespace LGA.Clima.Domain.Model.PrevisaoTempo
{
    public interface IPrevisaoTempoRepository<T, TKey> : IRepository<T, TKey> where T : Entity<TKey>
    {
    }
}
