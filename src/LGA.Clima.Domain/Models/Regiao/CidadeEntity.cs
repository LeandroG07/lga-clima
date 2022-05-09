using LGA.Clima.Domain.Models.Abstractions;

namespace LGA.Clima.Domain.Models.Regiao
{
    public class CidadeEntity<TKey> : Entity<TKey>
    {

        public CidadeEntity(TKey idCidade, string nome) : base(idCidade)
        {
            Nome = nome;
        }

        public string Nome { get; } 

    }
}
