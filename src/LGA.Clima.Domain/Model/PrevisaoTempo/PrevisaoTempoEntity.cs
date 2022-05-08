using LGA.Clima.Domain.Model.Regiao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Clima.Domain.Model.PrevisaoTempo
{
    public class PrevisaoTempoEntity
    {
        public PrevisaoTempoEntity(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public IEnumerable<CidadeEntity>? Cidades { get; }

    }
}
