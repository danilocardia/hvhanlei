﻿using System;
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

            if (data[4].Contains("VALOR"))
                return null; 

            return new ItemModel()
            {
                Site = data[0],
                Url = data[1],
                DtInicio = data[2],
                Entidade = data[3],
                Valor = data[4],
                UF = data[5],
                Cidade = data[6],
                Endereco = data[7],
                CEP = data[8]
            };
        }

        public void Clear()
        {
            Cod = Util.Clean(Cod);
            Valor = Util.Clean(Valor);
            Cidade = Util.Clean(Cidade);
            UF = Util.Clean(UF);
            DtInicio = Util.Clean(DtInicio);
            Endereco = Util.Clean(Endereco);
            Url = Util.Clean(Url);
            Tipo = Util.Clean(Tipo);
            CEP = Util.Clean(CEP);
            Entidade = Util.Clean(Entidade);
            Site = Util.Clean(Site);
            InformacoesAdicionais = Util.Clean(InformacoesAdicionais);
        }
    }
}
