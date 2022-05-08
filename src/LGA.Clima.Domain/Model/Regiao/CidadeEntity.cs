using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Clima.Domain.Model.Regiao
{
    public class CidadeEntity
    {

        public CidadeEntity(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; } 

    }
}
