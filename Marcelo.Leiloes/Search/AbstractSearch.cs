using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Search
{
    public abstract class AbstractSearch
    {
        protected SearchDataBag Config = new SearchDataBag();
        protected WebClient wc = new WebClient() { Encoding = System.Text.Encoding.GetEncoding("iso-8859-1") };

        public delegate void ItemFinished(ItemModel item);
        public event ItemFinished OnItemFinished;
        protected void InvokeItemFinished(ItemModel item)
        {
            OnItemFinished?.Invoke(item);
        }

        public virtual void Process()
        {

        }

        protected string GetSponsorFrom(string from)
        {
            from = Util.Clear(from);
            from = from.ToLower();
            from = RemoverAcentos(from);

            List<string> sponsors = new List<string>()
            {
                "itau",
                "bradesco",
                "caixa",
                "brasil",
                "gerdau",
                "porto seguro",
                "f. s. prestacao de servicos",
                "i c",
                "spe ltda",
                "grupo pan",
                "vasp"
            };

            foreach(string sponsor in sponsors)
            {
                if(from.ToLower().Contains(sponsor))
                {
                    return sponsor;
                }
            }

            return null;
        }

        protected string GetTipoFrom(string from)
        {
            from = from.ToLower();

            List<string> tipos = new List<string>()
            {
                "casa",
                "terreno",
                "apartamento",
                "rural",
                "residencial",
                "comercial",
                "galpão",
                "galpões",
                "industrial"
            };

            foreach (string tipo in tipos)
            {
                if (from.ToLower().Contains(tipo))
                {
                    return tipo.ToUpper();
                }
            }

            return null;
        }

        private string RemoverAcentos(string s)
        {
            s = s.ToLower();

            string comp = "áàãâäéèêëíìiîóòôõöúùûüç";
            string subs = "aaaaaeeeeiiiiooooouuuuc";

            string ret = "";
            foreach (char c in s)
            {
                ret += comp.IndexOf(c) >= 0 ? subs[comp.IndexOf(c)] : c;
            }

            return ret;
        }
    }

    public class SearchDataBag
    {
        public string _url = "";
        public int _pageCount = 0;
        public int _itemsPerPage = 0;
    }
}
