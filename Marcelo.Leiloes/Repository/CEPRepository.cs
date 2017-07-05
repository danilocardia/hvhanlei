using Marcelo.Leiloes.Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Leiloes.Repository
{
    public static class CEPRepository
    {
        private static List<CEPModel> _repository = null;
        public static List<CEPModel> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new List<CEPModel>();

                    using (var fs = File.OpenRead(@"cep_br.csv"))
                    {
                        using (var reader = new StreamReader(fs))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                if (values.Count() < 5 || String.IsNullOrEmpty(values[4]) || String.IsNullOrEmpty(values[4].Replace(" ", "")))
                                    continue;

                                _repository.Add(new CEPModel()
                                {
                                    UF = values[0],
                                    Cidade = values[1],
                                    CidadeSemAcentos = RemoverAcentos(values[1]),
                                    Bairro = values[2],
                                    BairroSemAcentos = RemoverAcentos(values[2]),
                                    Logradouro = values[3],
                                    LogradouroSemAcentos = RemoverAcentos(values[3]),
                                    CEP = values[4]
                                });
                            }
                        }
                    }
                }

                return _repository;
            }
        }

        private static List<string> _ufs = null;
        public static List<string> UFs
        {
            get
            {
                if (_ufs == null)
                {
                    _ufs = Repository.Select(c => c.UF).Distinct().ToList();
                }

                return _ufs;
            }
        }

        public static float CalculaCorrespondencias(CEPModel c, string searchFrom, bool onlyForCity = false)
        {
            var searchTokens = searchFrom.Split(' ')
                    .SelectMany(t => t.Split('.')
                        .SelectMany(t2 => t2.Split(',')
                            .SelectMany(t3 => t3.Split('-'))));

            var comparisonTokens = c.CidadeSemAcentos.Split(' ')
                    .SelectMany(t => t.Split('.')
                        .SelectMany(t2 => t2.Split(',')
                            .SelectMany(t3 => t3.Split('-'))));

            if (!onlyForCity)
            {
                comparisonTokens = comparisonTokens.Union(c.LogradouroSemAcentos.Split(' ')
                        .SelectMany(t => t.Split('.')
                            .SelectMany(t2 => t2.Split(',')
                                .SelectMany(t3 => t3.Split('-')))));

                comparisonTokens = comparisonTokens.Union(c.BairroSemAcentos.Split(' ')
                        .SelectMany(t => t.Split('.')
                            .SelectMany(t2 => t2.Split(',')
                                .SelectMany(t3 => t3.Split('-')))));
            }

            int matchCount = 0;

            foreach (var token in searchTokens)
            {
                if (String.IsNullOrEmpty(token))
                    continue;

                if (comparisonTokens.Contains(token))
                    matchCount++;
            }

            return (float)matchCount / (float)searchTokens.Count();
        }

        public static string GetBy(string address, string city)
        {
            if (String.IsNullOrEmpty(address))
                return "";

            var addressClean = RemoverAcentos(Util.Clean(address));
            var cityClean = RemoverAcentos(Util.Clean(city));

            var ceps = Repository.Where(c => addressClean.Contains(c.LogradouroSemAcentos) && addressClean.Contains(c.CidadeSemAcentos)).ToList();

            if (ceps.Count() == 0)
                return "";

            var filteredByToken = ceps.Select(c => new
            {
                CEP = c,
                Correspondencias = CalculaCorrespondencias(c, addressClean + cityClean)
            }).OrderBy(c => c.Correspondencias);

            var cep = filteredByToken.Where(c => c.Correspondencias >= 0.35f).Select(c => c.CEP).LastOrDefault();

            if (cep == null)
            {
                filteredByToken = ceps.Select(c => new
                {
                    CEP = c,
                    Correspondencias = CalculaCorrespondencias(c, Similarity.Similarity.GetSimilarFrom(addressClean) + cityClean)
                }).OrderBy(c => c.Correspondencias);

                cep = filteredByToken.Where(c => c.Correspondencias >= 0.35f).Select(c => c.CEP).LastOrDefault();
            }

            /*if(cep == null)
            {
                var filteredByCity = ceps.Select(c => new {
                    CEP = c,
                    Correspondencias = CalculaCorrespondencias(c, cityClean, true)
                }).OrderBy(c => c.Correspondencias);

                cep = filteredByCity.Where(c => c.Correspondencias >= 0.65f).Select(c => c.CEP).LastOrDefault();
            } funciona bem mas n diferencia utilizando o UF */

            if (cep == null)
                return "";

            return cep.CEP;
        }

        static string RemoverAcentos(string s)
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

        public static Dictionary<string, string> UFTranslate = new Dictionary<string, string>()
        {
            { "Acre", "AC" },
            { "Alagoas", "AL" },
            { "Amapá", "AP" },
            { "Amapa", "AP" },
            { "Amazonas", "AM" },
            { "Bahia", "BA" },
            { "Ceará", "CE" },
            { "Ceara", "CE" },
            { "Distrito Federal", "DF" },
            { "Espírito Santo", "ES" },
            { "Espirito Santo", "ES" },
            { "Goiás", "GO" },
            { "Goias", "GO" },
            { "Maranhão", "MA" },
            { "Maranhao", "MA" },
            { "Mato Grosso", "MT" },
            { "Mato Grosso do Sul", "MS" },
            { "Minas Gerais", "MG" },
            { "Pará", "PA" },
            { "Para", "PA" },
            { "Paraíba", "PB" },
            { "Paraiba", "PB" },
            { "Paraná", "PR" },
            { "Parana", "PR" },
            { "Pernambuco", "PE" },
            { "Piauí", "PI" },
            { "Piaui", "PI" },
            { "Rio de Janeiro", "RJ" },
            { "Rio Grande do Norte", "RN" },
            { "Rio Grande do Sul", "RS" },
            { "Rondônia", "RO" },
            { "Rondonia", "RO" },
            { "Roraima", "RR" },
            { "Santa Catarina", "SC" },
            { "São Paulo", "SP" },
            { "Sao Paulo", "SP" },
            { "Sergipe", "SE" },
            { "Tocantins", "TO" }
        };
    }
}
