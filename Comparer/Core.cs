using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparerAPI
{
    public class Core
    {
        public static float GetSimilarity( Article art1, Article art2 )
        {
            Topics t1 = art1.GetTopics();
            Topics t2 = art2.GetTopics();

            t1.ShowDebug();

            Console.WriteLine("=========");

            t2.ShowDebug();

            return 0.0f;
        }
    }
}
