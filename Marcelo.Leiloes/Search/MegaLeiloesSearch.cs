using Marcelo.Leiloes.Repository;
using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Search
{
    public class MegaLeiloesSearch : AbstractSearch
    {
        private List<string> foundItems = new List<string>();

        public MegaLeiloesSearch()
        {
            Config = new Search.SearchDataBag()
            {
                _url = "http://megaleiloes.com.br/leiloes-extrajudiciais"
            };
        }

        public override void Process()
        {
            ProcessRootPageMegaLeiloes(Config._url);
        }

        void ProcessRootPageMegaLeiloes(string url)
        {
            wc.Encoding = Encoding.UTF8;

            CsQuery.CQ root = WebUtility.HtmlDecode(wc.DownloadString(url));

            var links = root.Find(".card-header");

            foreach (var l in links.Elements)
            {
                if (foundItems.Contains(l.Attributes["href"]))
                {
                    return;
                }

                if (l.Attributes["href"].Contains("/ML"))
                {
                    ProcessRootPageMegaLeiloes(l.Attributes["href"]);
                    continue;
                }

                try
                {
                    var item = GetItem(l.Attributes["href"]);

                    InvokeItemFinished(item);

                    foundItems.Add(item.Url);
                }
                catch
                {

                }
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
