using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Repository.Models
{
    [Serializable()]
    public class ItemModel
    {
        public string Cod { get; set; }
        public string Valor { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public string DtInicio { get; set; }
        public string Endereco { get; set; }
        public string Url { get; set; }
        public string Tipo { get; set; }
        public string CEP { get; set; }
        public string Entidade { get; set; }
        public string Site { get; set; }
        public string InformacoesAdicionais { get; set; }
        public bool Falha { get; set; }

        public static ItemModel FromString(string from)
        {
            string[] data = from.Split(';');

            if (data.Length < 9)
                return null;

            if (data[5].Contains("VALOR"))
                return null; 

            return new ItemModel()
            {
                Site = data[0],
                Url = data[1],
                DtInicio = data[2],
                Entidade = data[4],
                Valor = data[5],
                UF = data[6],
                Cidade = data[7],
                Endereco = data[8],
                CEP = data[9]
            };
        }

        public void Clear()
        {
            Cod = Util.Clear(Cod);
            Valor = Util.Clear(Valor);
            Cidade = Util.Clear(Cidade);
            UF = Util.Clear(UF);
            DtInicio = Util.Clear(DtInicio);
            Endereco = Util.Clear(Endereco);
            Url = Util.Clear(Url);
            Tipo = Util.Clear(Tipo);
            CEP = Util.Clear(CEP);
            Entidade = Util.Clear(Entidade);
            Site = Util.Clear(Site);
            InformacoesAdicionais = Util.Clear(InformacoesAdicionais);
        }
    }
}
