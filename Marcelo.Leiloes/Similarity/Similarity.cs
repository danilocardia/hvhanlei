using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Similarity
{
    public class Similarity
    {
        public static string GetSimilarFrom(string from)
        {
            foreach (KeyValuePair<string, string> i in SimilarPairs)
            {
                from = from.Replace(i.Key, i.Value);
            }

            return from;
        }

        private static Dictionary<string, string> SimilarPairs = new Dictionary<string, string>()
        {
            {"Al","ALAMEDA" },
            {"Av","AVENIDA" },
            {"BC","BECO" },
            {"C","CAMPO" },
            {"Estr","ESTRADA" },
            {"Faz","FAZENDA" },
            {"Fz","FAZENDA" },
            {"JRD","JARDIM" },
            {"JD","JARDIM" },
            {"LAD","LADEIRA" },
            {"LRG","LARGO" },
            {"PQE","PARQUE" },
            {"PQ","PARQUE" },
            {"PRC","PRAÇA" },
            {"ROD","RODOVIA" },
            {"R","RUA" },
            {"TRV","TRAVESSA" },
            {"TV","TRAVESSA" },
            {"VIL","VILA" },
            {"VL","VILA" }
        };
    }
}
