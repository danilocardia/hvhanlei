using Marcelo.Leiloes.Repository;
using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Search
{
    public class FreitasSearch : AbstractSearch
    {
        private List<string> foundItems = new List<string>();
        private int ultimaPagina = 1;

        public FreitasSearch()
        {
            Config = new Search.SearchDataBag()
            {
                _url = ""
            };
        }

        public override void Process()
        {
            ProcessRootPage(Config._url);
        }

        void ProcessRootPage(string url)
        {
            int idx = 1;

            while (true)
            {
                InvokeItemFinished(new Repository.Models.ItemModel() { Cod = (idx++).ToString() });
                Thread.Sleep(new Random().Next(800, 9000));
            }
        }

        ItemModel GetItem(string url, string tipo = "")
        {
            ItemModel info = new ItemModel();

            wc.Encoding = Encoding.UTF8;

            CsQuery.CQ root = wc.DownloadString(url);

            var desc = root.Find(".description li");

            info.Cod = desc.ElementAt(1)?.InnerText.Trim();
            info.Valor = desc.ElementAt(2)?.InnerText.Trim();

            string cidadeEstado = desc.ElementAt(5).LastElementChild.InnerText;
            info.Cidade = cidadeEstado.Split(',')[0];
            info.UF = cidadeEstado.Split(',')[1];

            info.DtInicio = desc.ElementAt(7).LastElementChild.InnerText;

            info.Endereco = root.Find("[width=\"20%\"]").Next("td").ElementAt(0).InnerText;

            info.InformacoesAdicionais = root.Find("#batch-description").ElementAt(0).InnerText;

            info.Entidade = root.Find(".table-nomargin tr td").ElementAt(1).InnerText;

            info.Tipo = tipo;
            info.Url = url;
            info.Site = "MEGALEILOES";

            return info;
        }
    }
}
