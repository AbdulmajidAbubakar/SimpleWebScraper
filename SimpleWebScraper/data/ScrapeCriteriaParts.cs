using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.data
{
    public class ScrapeCriteriaParts
    {
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
    }
}
