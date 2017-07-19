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

        public Article() { }
        public Article(string data)
        {
            //Data being article in some form

            baseText = data;
        }

        public Topics GetTopics()
        {
            Topics results = new Topics();

            string[] wordList = baseText.Split(null);
            for (int i=0; i<wordList.Length; i++)
            {
                results.AddWord(wordList[i]);
            }

            return results;
        }
    }
}
