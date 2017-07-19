using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparerAPI
{
    public class Topics
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if ( String.IsNullOrWhiteSpace(word) ) return;

            if (words.ContainsKey( word ))
            {
                words[word]++;
            }
            else
            {
                words.Add(word, 1);
            }
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> GetOrdered()
        {
            return words.OrderBy(x => x.Value);
        }

        public void ShowDebug()
        {
            //var ordered = words.OrderBy( x => x.Value );

            foreach( KeyValuePair<string,int> entry in GetOrdered() )
            {
                //Console.WriteLine("(");
                Console.WriteLine(entry.Value + " > " + entry.Key);
                //Console.WriteLine(")");
            }
        }
    }
}
