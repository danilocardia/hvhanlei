using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Repository.Models
{
    public class CEPModel
    {
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string CidadeSemAcentos { get; set; }
        public string Bairro { get; set; }
        public string BairroSemAcentos { get; set; }
        public string Logradouro { get; set; }
        public string LogradouroSemAcentos { get; set; }
        public string CEP { get; set; }

    }
}
