using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            ComparerAPI.Article a1 = new ComparerAPI.Article(System.IO.File.ReadAllText("../../../articles/1.txt"));
            ComparerAPI.Article a2 = new ComparerAPI.Article(System.IO.File.ReadAllText("../../../articles/2.txt"));

            float res = ComparerAPI.Core.GetSimilarity(a1, a2);
        }
    }
}
