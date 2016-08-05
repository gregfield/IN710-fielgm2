using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fielgm2_WebNewsAggregator
{
    //the relevant information needed from the bing json
    public class SearchResult
    {
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
    }
}
