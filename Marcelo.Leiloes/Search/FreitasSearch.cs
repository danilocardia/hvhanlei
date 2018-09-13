using CsQuery;
using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Marcelo.Leiloes.Search
{
    public class FreitasSearch : AbstractSearch
    {
        private List<string> foundItems = new List<string>();

        public FreitasSearch()
        {
            Config = new Search.SearchDataBag()
            {
                _url = "https://www.freitasleiloeiro.com.br/leiloes/pesquisar?pg=1&categoria=2"
            };
        }

        public override void Process()
        {
            int qtdPaginas;

            wc.Encoding = Encoding.UTF8;
            CQ root = WebUtility.HtmlDecode(wc.DownloadString(Config._url));
            var pagination = root.Find(".pagination-container ul li a");

            if (!Int32.TryParse(pagination.ElementAt(pagination.Length - 2).InnerText, out qtdPaginas))
                return;

            for (int i = 1; i <= qtdPaginas; i++)
            {
                ProcessRootPage($"https://www.freitasleiloeiro.com.br/leiloes/pesquisar?pg={i}&categoria=2");
            }
        }

        void ProcessRootPage(string url)
        {
            wc.Encoding = Encoding.UTF8;

            CQ root = WebUtility.HtmlDecode(wc.DownloadString(url));

            var links = root.Find("#table_agenda_body .cursor-pointer");

            foreach (var l in links.Elements)
            {
                string destUrl = l.GetAttribute("onclick").Replace("self.location=", "").Replace("'", "");

                destUrl = Config._url.Replace("/leiloes/pesquisar?pg=1&categoria=2", "") + destUrl;

                if (foundItems.Contains(destUrl))
                {
                    continue;
                }

                try
                {
                    var item = GetItem(destUrl);

                    if (item != null)
                    {
                        InvokeItemFinished(item);

                        foundItems.Add(item.Url);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        ItemModel GetItem(string url, string tipo = "")
        {
            ItemModel info = new ItemModel();

            wc.Encoding = Encoding.UTF8;

            CQ root = wc.DownloadString(url);

            info.Cod = url.Substring(url.IndexOf("=") + 1, url.IndexOf("&") - url.IndexOf("=") - 1) + " - " +
                       url.Substring(url.LastIndexOf("=") + 1);

            info.InformacoesAdicionais = root.Find("#txtDescNota").FirstElement().InnerText.Trim();

            info.Valor = root.Find(".table-striped td").FirstElement().InnerText.Replace("R$", "").Replace(".", "").Trim();

            info.DtInicio = root.Find("#lblTipoStatusLote span").ElementAt(0).InnerText;

            info.Entidade = GetSponsorFrom(root.Find(".jumbotron h3").FirstElement().InnerText);

            info.Tipo = GetTipoFrom(info.InformacoesAdicionais);

            info.Falha = false;
            info.Url = url;
            info.Site = "FREITAS";

            return info;
        }
    }
}
