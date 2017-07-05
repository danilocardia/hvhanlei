using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Repository
{
    [Serializable]
    public class ItemRepository : AbstractRepository<ItemModel>
    {
        protected override string fileName { get; set; } = "founditems.bin";

        private static ItemRepository _instance = null;
        public static ItemRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ItemRepository();
                _instance.LoadFromFile();
            }

            return _instance;
        }
    }
}
