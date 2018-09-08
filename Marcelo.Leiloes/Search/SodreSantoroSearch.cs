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
    public class SodreSantoroSearch : AbstractSearch
    {
        private List<string> foundItems = new List<string>();
        public SodreSantoroSearch()
        {
            Config = new Search.SearchDataBag()
            {
                _url = "https://www.sodresantoro.com.br/imoveis/"
            };
        }

        public override void Process()
        {
            int qtdLotes;
            int qtdPorPagina = 50;
            int paginas;

            wc.Encoding = Encoding.UTF8;
            CsQuery.CQ root = WebUtility.HtmlDecode(wc.DownloadString(Config._url));
            var totalLotes = root.Find(".cabecalho-resultadoBusca b");
        
            if (!Int32.TryParse(totalLotes.ElementAt(0).InnerText, out qtdLotes))
                return;

            paginas = ((int) qtdLotes / qtdPorPagina) + 1;

            for (int i = 1; i <= paginas; i++)
            {
                ProcessRootPage($"https://www.sodresantoro.com.br/imoveis/ordenacao/inicio/tipo-ordenacao/crescente/qtde-itens/{qtdPorPagina}/visualizacao/visual_imagem/item-atual/1/pagina/{i}/");
            }
        }

        void ProcessRootPage(string url)
        {
            wc.Encoding = Encoding.UTF8;

            CsQuery.CQ root = WebUtility.HtmlDecode(wc.DownloadString(url));

            var links = root.Find(".tipo-vizualizacao li");

            foreach (var l in links.Elements)
            {
                string destUrl = l.ChildElements.ElementAt(1)?.ChildElements.ElementAt(0)?.FirstElementChild?.GetAttribute("href");

                destUrl = Config._url.Replace("/imoveis", "") + destUrl;

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

        ItemModel GetItem(string url)
        {
            ItemModel info = new ItemModel();

            wc.Encoding = Encoding.Default;

            CsQuery.CQ root = wc.DownloadString(url);

            var Codigo = root.Find(".online_lance-tit-esq h1").ElementAt(0).InnerText;
            if(Codigo.Length >= 23)
                info.Cod = Codigo.Substring(13, 11);

            info.Valor = root.Find(".online_lance-tit-dir span").ElementAt(1).InnerText.Replace("R$", "").Replace(".","").Trim();

            var descricao = root.Find(".online_desc_lote");
            info.DtInicio = descricao.Find("p").ElementAt(2).LastElementChild.InnerText.Trim();
            info.InformacoesAdicionais = descricao.ElementAt(2).Cq().Find("p strong").ElementAt(0).InnerText; //os que dão erro aqui é pq o leilão foi RETIRADO
            info.Tipo = descricao.ElementAt(2).Cq().Find("li p strong").ElementAt(1).InnerText;
            info.Cidade = descricao.ElementAt(2).Cq().Find("li p strong").ElementAt(3).InnerText.Split('/')[0].Trim();
            info.UF = descricao.ElementAt(2).Cq().Find("li p strong").ElementAt(3).InnerText.Replace("/ /", "/").Split('/')[1].Trim();
            info.Bairro = descricao.ElementAt(2).Cq().Find("li p strong").ElementAt(4).InnerText.Trim();
            info.Endereco = descricao.ElementAt(2).Cq().Find("li p strong").ElementAt(5).InnerText.Trim();

            info.Falha = false;

            info.Entidade = GetSponsorFrom(url);

            info.Url = url;
            info.Site = "SODRESANTORO";

            return info;
        }
    }
}

