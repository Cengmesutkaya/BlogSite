using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Utils
{
    public class UrlDuzenleme
    {
        public static string UrlCevir(string kelime)
        {
            if (kelime == "" || kelime == null) { return string.Empty; }

            kelime = kelime.Replace(".", "");
            kelime = kelime.Replace(":", "");
            kelime = kelime.Replace(";", "");
            kelime = kelime.Replace(",", "");
            kelime = kelime.Replace(" ", "-");
            kelime = kelime.Replace("!", "");
            kelime = kelime.Replace("(", "");
            kelime = kelime.Replace(")", "");
            kelime = kelime.Replace("'", "'");
            kelime = kelime.Replace("ğ", "g");
            kelime = kelime.Replace("Ğ", "G");
            kelime = kelime.Replace("ı", "i");
            kelime = kelime.Replace("I", "i");
            kelime = kelime.Replace("ç", "c");
            kelime = kelime.Replace("Ç", "C");
            kelime = kelime.Replace("ö", "o");
            kelime = kelime.Replace("Ö", "O");
            kelime = kelime.Replace("ü", "u");
            kelime = kelime.Replace("Ü", "U");
            kelime = kelime.Replace("ş", "s");
            kelime = kelime.Replace("Ş", "S");
            kelime = kelime.Replace("`", "");
            kelime = kelime.Replace("=", "");
            kelime = kelime.Replace("&", "");
            kelime = kelime.Replace("%", "");
            kelime = kelime.Replace("#", "");
            kelime = kelime.Replace("<", "");
            kelime = kelime.Replace(">", "");
            kelime = kelime.Replace("*", "");
            kelime = kelime.Replace("?", "");
            kelime = kelime.Replace("+", "-");
            kelime = kelime.Replace("\"", "-");
            kelime = kelime.Replace("»", "-");
            kelime = kelime.Replace("|", "-");
            kelime = kelime.Replace("^", "");
            return kelime;
        }

    }
}