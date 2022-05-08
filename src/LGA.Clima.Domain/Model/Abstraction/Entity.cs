
namespace LGA.Clima.Domain.Model.Abstraction
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
