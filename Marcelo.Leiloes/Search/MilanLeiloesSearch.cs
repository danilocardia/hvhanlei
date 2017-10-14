using CsQuery;
using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Search
{
    public class MilanLeiloesSearch : AbstractSearch
    {
        private List<string> foundItems = new List<string>();
        public MilanLeiloesSearch()
        {
            Config = new Search.SearchDataBag()
            {
                _url = "https://www.milanleiloes.com.br/Leiloes/Agenda.asp?Categ=3"
            };
        }

        public override void Process()
        {
            ProcessRootPage(Config._url);
        }

        void ProcessRootPage(string url)
        {
            wc.Encoding = Encoding.UTF8;

            CsQuery.CQ root = WebUtility.HtmlDecode(wc.DownloadString(url));

            var links = root.Find(".caixa-1de4.cursorLink");

            foreach (var l in links.Elements)
            {
                string destUrl = l.Attributes["onclick"];
                string[] split = destUrl.Replace("AbrirPagLeilao(", "").Replace("'", "").Replace(" ", "").Split(',');

                if (split.Length != 4 || split[1] == "catalogo")
                    continue;

                destUrl = "https://www.milanleiloes.com.br/Editais/" + split[2].Replace("[CodLeilao]", split[0]);

                if (foundItems.Contains(destUrl))
                {
                    continue;
                }

                /*if (l.Attributes["href"].Contains("/ML"))
                {
                    ProcessChildList(l.Attributes["href"]);
                    continue;
                }*/

                try
                {
                    var item = GetItem(destUrl, cidadeUf: l.Cq().Find(".descricaoLeilao").ElementAt(0)?.InnerText);

                    if (item != null)
                    {
                        InvokeItemFinished(item);

                        foundItems.Add(item.Url);
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }

        ItemModel GetItem(string url, string tipo = "", string cidadeUf = "")
        {
            ItemModel info = new ItemModel();

            wc.Encoding = Encoding.Default;

            CsQuery.CQ root = wc.DownloadString(url);

            var destaque = root.Find(".destaque.proximo td");
            var desc = root.Find(".quadro-msg-full span span");

            info.Valor = destaque.ElementAt(2).InnerText;

            info.DtInicio = destaque.ElementAt(1).InnerText;

            var cduf = cidadeUf.Split('-');

            info.UF = cduf[1].Replace(" ", "").Substring(0, 2);
            info.Cidade = cduf[0].TrimStart(' ', '\t', '\n', '\r');
            
            info.Falha = true;

            info.Entidade = GetSponsorFrom(url);

            info.Tipo = tipo;
            info.Url = url;
            info.Site = "MILANLEILOES";
            info.InformacoesAdicionais = Util.StripHTML(root.Find(".loteDescricao").ElementAt(0).InnerHTML);

            return info;
        }
    }
}

