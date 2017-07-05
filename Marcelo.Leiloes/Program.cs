using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Marcelo.Leiloes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class Util
    {

        static Dictionary<string, string> replaces = null;
        public static string Clean(string p)
        {
            if (replaces == null)
            {
                replaces = new Dictionary<string, string>();
                replaces.Add("&#38;", "&");
                replaces.Add("&#60;", "<");
                replaces.Add("&#62;", ">");
                replaces.Add("&#160;", "");
                replaces.Add("&#161;", "¡");
                replaces.Add("&#162;", "¢");
                replaces.Add("&#163;", "£");
                replaces.Add("&#164;", "¤");
                replaces.Add("&#165;", "¥");
                replaces.Add("&#166;", "¦");
                replaces.Add("&#167;", "§");
                replaces.Add("&#168;", "¨");
                replaces.Add("&#169;", "©");
                replaces.Add("&#170;", "ª");
                replaces.Add("&#171;", "«");
                replaces.Add("&#172;", "¬");
                replaces.Add("&#173;", "");
                replaces.Add("&#174;", "®");
                replaces.Add("&#175;", "¯");
                replaces.Add("&#176;", "°");
                replaces.Add("&#177;", "±");
                replaces.Add("&#178;", "²");
                replaces.Add("&#179;", "³");
                replaces.Add("&#180;", "´");
                replaces.Add("&#181;", "µ");
                replaces.Add("&#182;", "¶");
                replaces.Add("&#183;", "·");
                replaces.Add("&#184;", "¸");
                replaces.Add("&#185;", "¹");
                replaces.Add("&#186;", "º");
                replaces.Add("&#187;", "»");
                replaces.Add("&#188;", "¼");
                replaces.Add("&#189;", "½");
                replaces.Add("&#190;", "¾");
                replaces.Add("&#191;", "¿");
                replaces.Add("&#192;", "À");
                replaces.Add("&#193;", "Á");
                replaces.Add("&#194;", "Â");
                replaces.Add("&#195;", "Ã");
                replaces.Add("&#196;", "Ä");
                replaces.Add("&#197;", "Å");
                replaces.Add("&#198;", "Æ");
                replaces.Add("&#199;", "Ç");
                replaces.Add("&#200;", "È");
                replaces.Add("&#201;", "É");
                replaces.Add("&#202;", "Ê");
                replaces.Add("&#203;", "Ë");
                replaces.Add("&#204;", "Ì");
                replaces.Add("&#205;", "Í");
                replaces.Add("&#206;", "Î");
                replaces.Add("&#207;", "Ï");
                replaces.Add("&#208;", "Ð");
                replaces.Add("&#209;", "Ñ");
                replaces.Add("&#210;", "Ò");
                replaces.Add("&#211;", "Ó");
                replaces.Add("&#212;", "Ô");
                replaces.Add("&#213;", "Õ");
                replaces.Add("&#214;", "Ö");
                replaces.Add("&#215;", "×");
                replaces.Add("&#216;", "Ø");
                replaces.Add("&#217;", "Ù");
                replaces.Add("&#218;", "Ú");
                replaces.Add("&#219;", "Û");
                replaces.Add("&#220;", "Ü");
                replaces.Add("&#221;", "Ý");
                replaces.Add("&#222;", "Þ");
                replaces.Add("&#223;", "ß");
                replaces.Add("&#224;", "à");
                replaces.Add("&#225;", "á");
                replaces.Add("&#226;", "â");
                replaces.Add("&#227;", "ã");
                replaces.Add("&#228;", "ä");
                replaces.Add("&#229;", "å");
                replaces.Add("&#230;", "æ");
                replaces.Add("&#231;", "ç");
                replaces.Add("&#232;", "è");
                replaces.Add("&#233;", "é");
                replaces.Add("&#234;", "ê");
                replaces.Add("&#235;", "ë");
                replaces.Add("&#236;", "ì");
                replaces.Add("&#237;", "í");
                replaces.Add("&#238;", "î");
                replaces.Add("&#239;", "ï");
                replaces.Add("&#240;", "ð");
                replaces.Add("&#241;", "ñ");
                replaces.Add("&#242;", "ò");
                replaces.Add("&#243;", "ó");
                replaces.Add("&#244;", "ô");
                replaces.Add("&#245;", "õ");
                replaces.Add("&#246;", "ö");
                replaces.Add("&#247;", "÷");
                replaces.Add("&#248;", "ø");
                replaces.Add("&#249;", "ù");
                replaces.Add("&#250;", "ú");
                replaces.Add("&#251;", "û");
                replaces.Add("&#252;", "ü");
                replaces.Add("&#253;", "ý");
                replaces.Add("&#254;", "þ");
                replaces.Add("&#255;", "ÿ");
                replaces.Add("&#402;", "ƒ");
                replaces.Add("&#913;", "Α");
                replaces.Add("&#914;", "Β");
                replaces.Add("&#915;", "Γ");
                replaces.Add("&#916;", "Δ");
                replaces.Add("&#917;", "Ε");
                replaces.Add("&#918;", "Ζ");
                replaces.Add("&#919;", "Η");
                replaces.Add("&#920;", "Θ");
                replaces.Add("&#921;", "Ι");
                replaces.Add("&#922;", "Κ");
                replaces.Add("&#923;", "Λ");
                replaces.Add("&#924;", "Μ");
                replaces.Add("&#925;", "Ν");
                replaces.Add("&#926;", "Ξ");
                replaces.Add("&#927;", "Ο");
                replaces.Add("&#928;", "Π");
                replaces.Add("&#929;", "Ρ");
                replaces.Add("&#931;", "Σ");
                replaces.Add("&#932;", "Τ");
                replaces.Add("&#933;", "Υ");
                replaces.Add("&#934;", "Φ");
                replaces.Add("&#935;", "Χ");
                replaces.Add("&#936;", "Ψ");
                replaces.Add("&#937;", "Ω");
                replaces.Add("&#945;", "α");
                replaces.Add("&#946;", "β");
                replaces.Add("&#947;", "γ");
                replaces.Add("&#948;", "δ");
                replaces.Add("&#949;", "ε");
                replaces.Add("&#950;", "ζ");
                replaces.Add("&#951;", "η");
                replaces.Add("&#952;", "θ");
                replaces.Add("&#953;", "ι");
                replaces.Add("&#954;", "κ");
                replaces.Add("&#955;", "λ");
                replaces.Add("&#956;", "μ");
                replaces.Add("&#957;", "ν");
                replaces.Add("&#958;", "ξ");
                replaces.Add("&#959;", "ο");
                replaces.Add("&#960;", "π");
                replaces.Add("&#961;", "ρ");
                replaces.Add("&#962;", "ς");
                replaces.Add("&#963;", "σ");
                replaces.Add("&#964;", "τ");
                replaces.Add("&#965;", "υ");
                replaces.Add("&#966;", "φ");
                replaces.Add("&#967;", "χ");
                replaces.Add("&#968;", "ψ");
                replaces.Add("&#969;", "ω");
                replaces.Add("&#977;", "ϑ");
                replaces.Add("&#978;", "ϒ");
                replaces.Add("&#982;", "ϖ");
                replaces.Add("&#8211;", "-");
                replaces.Add(";", "");
                replaces.Add("\n", " ");
                replaces.Add("(inteior)", "");
                replaces.Add("(capital)", " ");
                replaces.Add("(INTERIOR)", "");
                replaces.Add("(CAPITAL)", " ");
                replaces.Add("(Interior)", "");
                replaces.Add("(Capital)", " ");
                replaces.Add(" (inteior)", "");
                replaces.Add(" (capital)", " ");
                replaces.Add(" (INTERIOR)", "");
                replaces.Add(" (CAPITAL)", " ");
                replaces.Add(" (Interior)", "");
                replaces.Add(" (Capital)", " ");
                replaces.Add(Environment.NewLine, " ");
            }

            if (p == null)
                return "";

            foreach (var rep in replaces)
            {
                p = p.Replace(rep.Key, rep.Value);
            }

            p = HttpUtility.HtmlDecode(p);

            if (!String.IsNullOrEmpty(p) && String.IsNullOrWhiteSpace(p.Substring(p.Length - 1, 1)))
            {
                p = p.Substring(0, p.Length - 1);
            }

            return p;
        }
    }

}