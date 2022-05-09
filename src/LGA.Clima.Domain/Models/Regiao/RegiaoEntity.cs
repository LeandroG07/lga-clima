using LGA.Clima.Domain.Models.Abstractions;

namespace LGA.Clima.Domain.Models.Regiao
{
    public class RegiaoEntity<TKey> : Entity<TKey>
    {
        public RegiaoEntity(TKey idRegiao, string nome, IEnumerable<CidadeEntity<TKey>> cidades) : base(idRegiao)
        {
            Nome = nome;
            Cidades = cidades;
        }

        public string Nome { get; }

        IEnumerable<CidadeEntity<TKey>> Cidades { get; }

    }
}
