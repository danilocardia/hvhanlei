using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcelo.Leiloes.Search
{
    public class ZuckermanSearch : AbstractSearch
    {
        int _limit;
        string[] _estados;
        private List<string> foundItems = new List<string>();
        private int ultimaPagina = 1;

        public ZuckermanSearch(string[] estados, int limit)
        {
            _estados = estados;
            _limit = limit;

            Config = new Search.SearchDataBag()
            {
                _url = "http://www.zukerman.com.br/leilao-de-imoveis/{uf}/todas-as-cidades/todos-os-bairros/residenciais"
            };
        }

        public override void Process()
        {
            Thread t = new Thread(() =>
            {
                foreach(var e in _estados)
                    ProcessRootPage(Config._url.Replace("{uf}", e));
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            while (t.IsAlive)
            {
                Thread.Sleep(1000);
            }
        }

        bool block = true;

        void ProcessRootPage(string url)
        {
            CsQuery.CQ root;

            using (WebBrowser wb = new WebBrowser())
            {
                wb.Navigated += (_, __) =>
                {
                    block = false;
                };
                wb.Navigate(url);
                Block();

                root = wb.DocumentText;
            }

            var links = root.Find(".cd-it-s-btn");

            foreach (var l in links.Elements)
            {
                if (_limit <= 0)
                    return;

                var itemUrl = l.ParentNode.Attributes["href"];

                if (foundItems.Contains(itemUrl.ToUpper()))
                {
                    ultimaPagina = 1;
                    return;
                }

                try
                {
                    var item = GetItem(itemUrl);

                    InvokeItemFinished(item);

                    foundItems.Add(item.Url.ToUpper());
                    _limit--;
                }
                catch (Exception ex)
                {

                }
            }

            if(links.Elements.Count() > 0)
                ProcessRootPage(url.Split('?')[0] + $"?pagina={++ultimaPagina}");
        }

        ItemModel GetItem(string url, string tipo = "")
        {
            ItemModel info = new ItemModel();
            CsQuery.CQ root;

            using (WebBrowser wb = new WebBrowser())
            {
                wb.Navigated += (_, __) =>
                {
                    block = false;
                };
                wb.Navigate(url);
                Block();

                root = wb.DocumentText;
            }

            info.Cod = root.Find(".s-d-lf-t").FirstOrDefault()?.InnerText?.Trim(' ', '-');
            info.Valor = root.Find(".dvla").FirstOrDefault()?.InnerText;

            string cidadeEstado = root.Find(".s-d-ld-i2 a").FirstOrDefault()?.InnerText;
            info.Cidade = cidadeEstado.Split('/')[0];
            info.UF = cidadeEstado.Split('/')[1];

            info.DtInicio = root.Find(".daet").LastOrDefault()?.InnerText;

            info.Endereco = root.Find(".s-d-ld-i2").FirstOrDefault()?.InnerText?.Trim(' ', '-');

            info.InformacoesAdicionais = root.Find(".s-d-ld").FirstOrDefault()?.InnerText;

            info.Entidade = root.Find(".d-n-v h2").FirstOrDefault()?.InnerText;

            info.Tipo = tipo;
            info.Url = url;
            info.Site = "ZUCKERMAN";

            return info;
        }

        void Block()
        {
            if (!block)
                block = true;

            do
            {
                Thread.Sleep(10);
                Application.DoEvents();
            } while (block);
        }
    }
}
