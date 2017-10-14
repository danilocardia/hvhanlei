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
            List<string> sponsors = new List<string>()
            {
                "itau",
                "bradesco",
                "caixa",
                "brasil",
                "gerdau"
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
    }

    public class SearchDataBag
    {
        public string _url = "";
        public int _pageCount = 0;
        public int _itemsPerPage = 0;
    }
}
