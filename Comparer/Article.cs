using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparerAPI
{
    public class Article
    {
        public string title;
        public DateTime postDate;
        public List<string> originalTags = new List<string>();
        public string baseText;

        public Topics GetTopics()
        {
            Topics results = new Topics();

            return results;
        }
    }
}
