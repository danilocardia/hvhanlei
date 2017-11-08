using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcelo.Leiloes.Search
{
    public class CaixaSearch : AbstractSearch
    {
        string[] _estados;
        DateTime _dataInicio;

        public CaixaSearch(string[] estados, DateTime dataInicio)
        {
            _estados = estados;
            _dataInicio = dataInicio;

            Config = new Search.SearchDataBag()
            {
                _url = "http://www1.caixa.gov.br/Simov/carregaListaLicitacoes.asp"
            };
        }

        public override void Process()
        {
            foreach (var estado in _estados)
            {
                Thread t = new Thread(() => ProcessRootPage(Config._url, estado, _dataInicio));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();

                while (t.IsAlive)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        bool block = true;

        void ProcessRootPage(string url, string estado, DateTime dataInicio)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigated += (_, __) =>
            {
                block = false;
            };
            wb.Navigate("http://www1.caixa.gov.br/Simov/busca-licitacoes.asp?sltTipoBusca=licitacoes");
            Block();

            HtmlElement head = wb.Document.GetElementsByTagName("head")[0];
            HtmlElement s = wb.Document.CreateElement("script");
            s.SetAttribute("text", @"function getData() 
                                        {   
                                            var strReturn;
                                            $.ajax({
                                              type: 'POST',
                                              url: 'http://www1.caixa.gov.br/Simov/carregaListaLicitacoes.asp',
                                              data: { cmb_estado: '" + estado + @"' },
                                              success: function(html) {
                                                      strReturn = html;
                                                    },
                                              async: false
                                            });
                                            return strReturn;
                                        }");
            head.AppendChild(s);
            string responseEdital = wb.Document.InvokeScript("getData").ToString();

            string tokenEdital = "javascript:ListarEdital('";
            int lastIndexEdital = responseEdital.IndexOf(tokenEdital);
            int firstIndex = 0;
            while (lastIndexEdital > 0)
            {
                bool pulaExecucao = false;
                wb.Navigate("http://www1.caixa.gov.br/Simov/busca-licitacoes.asp?sltTipoBusca=licitacoes");
                Block();

                string dataLeilao = "";
                List<DateTime> datasEncontradas = new List<DateTime>();
                int idxBarra = responseEdital.IndexOf("/", firstIndex);
                while (idxBarra > firstIndex && idxBarra < lastIndexEdital)
                {
                    int idxProxBarra = responseEdital.IndexOf("/", idxBarra + 1);

                    if ((idxProxBarra - idxBarra - "/".Length) != 2)
                    {
                        idxBarra = responseEdital.IndexOf("/", idxBarra + 1);
                        continue;
                    }

                    int dateStartIdx = idxBarra - "dd".Length;
                    dataLeilao = responseEdital.Substring(dateStartIdx, (idxProxBarra + "/yyyy".Length) - dateStartIdx);

                    var dataParts = dataLeilao.Split('/');
                    datasEncontradas.Add(new DateTime(Convert.ToInt32(OnlyNumbers(dataParts[2])), Convert.ToInt32(OnlyNumbers(dataParts[1])), Convert.ToInt32(OnlyNumbers(dataParts[0]))));

                    idxBarra++;
                }

                if (datasEncontradas.Count == 0)
                {
                    dataLeilao = "data não encontrada";
                }
                else if (datasEncontradas.Count == 1)
                {
                    var dtEscolhida = datasEncontradas.ElementAt(0);

                    if (dtEscolhida < dataInicio)
                        pulaExecucao = true;

                    dataLeilao = dtEscolhida.ToString("dd/MM/yyyy");
                }
                else
                {
                    var dtEscolhida = datasEncontradas.ElementAt((datasEncontradas.Count - 1 /* base zero */) - 1 /* pega o penultimo item */);

                    if (dtEscolhida < dataInicio)
                        pulaExecucao = true;

                    dataLeilao = dtEscolhida.ToString("dd/MM/yyyy");
                }

                firstIndex = lastIndexEdital;
                if (!pulaExecucao)
                {
                    lastIndexEdital = lastIndexEdital + tokenEdital.Length;

                    int nextApsIndex = responseEdital.IndexOf("'", lastIndexEdital); // abre string
                    var p1 = responseEdital.Substring(lastIndexEdital, nextApsIndex - lastIndexEdital);

                    lastIndexEdital = nextApsIndex + 1;
                    nextApsIndex = responseEdital.IndexOf("'", lastIndexEdital); // fecha string

                    lastIndexEdital = nextApsIndex + 1;
                    nextApsIndex = responseEdital.IndexOf("'", lastIndexEdital); // abre string
                    var p2 = responseEdital.Substring(lastIndexEdital, nextApsIndex - lastIndexEdital);

                    lastIndexEdital = nextApsIndex + 1;
                    nextApsIndex = responseEdital.IndexOf("'", lastIndexEdital); // fecha string

                    lastIndexEdital = nextApsIndex + 1;
                    nextApsIndex = responseEdital.IndexOf("'", lastIndexEdital); // abre string
                    var p3 = responseEdital.Substring(lastIndexEdital, nextApsIndex - lastIndexEdital);

                    head = wb.Document.GetElementsByTagName("head")[0];
                    s = wb.Document.CreateElement("script");
                    s.SetAttribute("text", @"function getHdns() 
                                        {   
                                            var strReturn;
                                            $.ajax({
                                              type: 'POST',
                                              url: 'http://www1.caixa.gov.br/Simov/carregaPesquisaImoveisLicitacoes.asp',
                                              data: { NumLicit: '" + p1 + @"', SgComissao: '" + p2 + @"', NumTipoVenda: '" + p3 + @"' },
                                              success: function(html) {
                                                      strReturn = html;
                                                    },
                                              async: false
                                            });
                                            return strReturn;
                                        }");
                    head.AppendChild(s);
                    string hdnsResponse = wb.Document.InvokeScript("getHdns").ToString();

                    CsQuery.CQ root = hdnsResponse;

                    var qtdPagEl = root.Elements.Where(el => el.Id == "hdnQtdPag").FirstOrDefault();
                    if (qtdPagEl == null)
                        return;

                    int qtdPag = Convert.ToInt32(qtdPagEl.Value);

                    List<string> cods = new List<string>();
                    for (int idx = 1; idx <= qtdPag; idx++)
                    {
                        var imvEl = root.Elements.FirstOrDefault(e => e.Id == $"hdnImov{idx}");

                        if (imvEl == null) continue;

                        cods.AddRange(imvEl.Value.Split('|').Where(v => !String.IsNullOrEmpty(v)));
                    }

                    foreach (var codg in cods)
                    {
                        try
                        {
                            string urlItem = $"http://www1.caixa.gov.br/Simov/detalhe-imovel.asp?hdnimovel={codg}";

                            wb.Navigate(urlItem);
                            Block();

                            string token = "Valor de venda: ";
                            int lastIndex = wb.DocumentText.IndexOf(token) + token.Length;
                            string valor = wb.DocumentText.Substring(lastIndex, wb.DocumentText.IndexOf("</h4>", lastIndex) - lastIndex);

                            token = "Endereço:</strong><br>";
                            lastIndex = wb.DocumentText.IndexOf(token) + token.Length;
                            string endereco = wb.DocumentText.Substring(lastIndex, wb.DocumentText.IndexOf("</p>", lastIndex) - lastIndex);

                            token = "Tipo de imóvel: <strong>";
                            lastIndex = wb.DocumentText.IndexOf(token) + token.Length;
                            string tipo = wb.DocumentText.Substring(lastIndex, wb.DocumentText.IndexOf("</strong>", lastIndex) - lastIndex);

                            ItemModel item = new ItemModel();
                            item.DtInicio = dataLeilao;
                            item.Valor = valor;
                            item.Endereco = endereco;
                            item.Entidade = "CAIXA";
                            item.Site = "CAIXA";
                            item.Tipo = tipo;
                            item.Url = urlItem;
                            item.Cod = $"Item No. {(cods.IndexOf(codg) + 1).ToString().PadLeft(2, '0')}";

                            InvokeItemFinished(item);
                        }
                        catch { }
                    }
                }

                lastIndexEdital = responseEdital.IndexOf("javascript:ListarEdital", ++lastIndexEdital);
            }

        }

        string OnlyNumbers(string s)
        {
            char[] arr = s.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-')));
            s = new string(arr);
            return s;
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
