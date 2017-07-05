using Marcelo.Leiloes.Repository;
using Marcelo.Leiloes.Repository.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Search
{
    public class VipLeiloesSearch : AbstractSearch
    {
        private List<string> foundItems = new List<string>();

        public VipLeiloesSearch()
        {
            Config = new Search.SearchDataBag()
            {
                _url = "https://www.leilaovip.com.br/ajaxhome/0/extrajudicial/0/0/0"
            };
        }

        public override void Process()
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(Config._url);

                var obj = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);

                // fazer o loop nos leilos do json e lá na process fazer a recursão para as internas
                foreach (var leilao in obj["Leilao"])
                {
                    ProcessRootPageLeiloesVip(leilao.Link.ToString());
                }
            }
        }

        void ProcessRootPageLeiloesVip(string url, int p = 1)
        {
            wc.Encoding = Encoding.UTF8;

            var pagurl = url + "?pag=" + p.ToString();
            CsQuery.CQ root = wc.DownloadString(pagurl);

            var links = root.Find(".btn-leilao a");

            if (links.Count() == 0)
            {
                return;
            }

            foreach (var link in links)
            {
                string url_child = link.Attributes["href"].Replace("../", "https://www.leilaovip.com.br/");

                var item = GetItem(url_child);

                InvokeItemFinished(item);

                foundItems.Add(item.Url);
            }

            ProcessRootPageLeiloesVip(url, p + 1);
        }

        ItemModel GetItem(string url, string tipo = "")
        {
            ItemModel info = new ItemModel();

            wc.Encoding = Encoding.UTF8;

            CsQuery.CQ root = wc.DownloadString(url);

            info.Cod = root.Find("#ContentPlaceHolder1_lblID").FirstOrDefault()?.InnerText.Trim();
            info.Valor = root.Find("#ContentPlaceHolder1_lblValorAtual").FirstOrDefault()?.InnerText.Trim();

            info.Cidade = root.Find("#ContentPlaceHolder1_lblCidade").FirstOrDefault()?.InnerText.Trim();

            info.DtInicio = root.Find("#ContentPlaceHolder1_lblDataleilao").FirstOrDefault()?.InnerText;

            info.Endereco = root.Find("#ContentPlaceHolder1_lblEndereco").FirstOrDefault()?.InnerText;

            var compl = root.Find("#ContentPlaceHolder1_lblDescricaoImovel").FirstOrDefault()?.InnerText;
            if (!String.IsNullOrEmpty(compl))
                info.Endereco += " COMPLEMENTO: " + compl;

            info.Entidade = url.Contains("BRA") ? "Bradesco" : (url.Contains("ITA") ? "Itaú" : (url.Contains("PAN") ? "Pan" : "Vivarella"));

            var searchUF = Util.Clean(root.Find("#ContentPlaceHolder1_lblEstado").FirstOrDefault()?.InnerText.ToUpper());
            var foundUF = CEPRepository.UFTranslate.Where(uf => uf.Key.ToUpper() == searchUF).Select(k => k.Value).FirstOrDefault();
            if (!String.IsNullOrEmpty(foundUF))
                info.UF = foundUF;

            //GetFromCEP(info);

            info.Tipo = tipo;
            info.Url = url;
            info.Site = "LEILAOVIP";

            return info;
        }
    }
}
