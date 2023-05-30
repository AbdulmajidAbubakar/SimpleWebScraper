using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.data
{
    public class ScrapeCriteria
    {
        public ScrapeCriteria() {
            parts = new List<ScrapeCriteriaParts>();
        }
        public string Data { get; set; }
        
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
        public List<ScrapeCriteriaParts> parts { get; set; }

    }
}
