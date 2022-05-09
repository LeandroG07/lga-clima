using LGA.Clima.Domain.Models.Abstractions;
using LGA.Clima.Domain.Models.Regiao;

namespace LGA.Clima.Domain.Models.PrevisaoTempo
{
    public class PrevisaoTempoEntity<TKey> : Entity<TKey>
    {
        public PrevisaoTempoEntity(TKey idPrevisaoTempo, string nome, RegiaoEntity<TKey> regiao) : base(idPrevisaoTempo)
        {
            Nome = nome;
            Regiao = regiao;
        }

        public string Nome { get; }

        public RegiaoEntity<TKey> Regiao { get; }

    }
}
