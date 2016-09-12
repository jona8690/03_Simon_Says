using System;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
            return v.ToLower();
        }

        internal string Shout(string v)
        {
            return v.ToUpper();
        }

        internal string Repeat(string v, int r = 2)
        {
            return string.Join(" ", Enumerable.Repeat(v,r));
        }

        /*internal object Repeat(string v1, int v2)
        {
            throw new NotImplementedException();
        }*/

        internal string StartOfWord(string v1, int v2)
        {
            return v1.Substring(0, v2);
        }

        internal string FirstWord(string v)
        {
            string[] fw;
            char[] space = { ' ' };
            fw = v.Split(space);
            return fw[0];
        }

        internal string Titleize(string v)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string[] cap;
            List<string> sreturn = new List<string>();
            char[] space = { ' ' };
            cap = v.Split(space);
            string[] nonCap = { "and", "over", "the" };
            Boolean firstRun = true;
            foreach(string word in cap)
            {
                if (!nonCap.Contains(word) || firstRun)
                {
                    firstRun = false;
                    sreturn.Add(textInfo.ToTitleCase(word));
                }
                else
                {
                    sreturn.Add(word);
                }
                
            }
            string[] areturn = sreturn.ToArray();
            return string.Join(" ", areturn);
        }
    }
}