
namespace LGA.Clima.Domain.Models.Abstractions
{
    public abstract class Entity<TKey>
    {

        public Entity(TKey id)
        {
            Id = id;
        }

        public TKey Id { get; }

    }
}
