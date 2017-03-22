using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KliPr.Models
{
    public class Colorgen
    {
        public Colorgen()
        {
            colors = new List<string>();
            colors.Add("#e72323");
            colors.Add("#e7bf23");
            colors.Add("#95e723");
            colors.Add("#23e75a");
            colors.Add("#23e0e7");
            colors.Add("#2357e7");
            colors.Add("#cc23e7");
        }
       public string getRandomCol()
        {
            if (colors.Count > 0)
            {

                var ret = colors[0];
                colors.RemoveAt(0);
                colors.Add(ret);
                return ret;
            }
            else
            {
                return null;
            }
        }

        public List<string> colors;
    }
}
