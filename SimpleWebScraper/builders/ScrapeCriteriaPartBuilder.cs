using SimpleWebScraper.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.builders
{
    public class ScrapeCriteriaPartBuilder
    {
        
        private string _regex;
        private RegexOptions _regexOption;
       public ScrapeCriteriaPartBuilder()
        {
            setDefault();
        }

        private void setDefault()
        {
            _regex= string.Empty;
            _regexOption = RegexOptions.None;
        }

        public ScrapeCriteriaPartBuilder withRexex(string rex)
        {
            _regex= rex;
            return this;
        }
        public ScrapeCriteriaPartBuilder withRegexOption(RegexOptions regexOption) {
            _regexOption= regexOption;
            return this;
        }

        public ScrapeCriteriaParts build() {
            ScrapeCriteriaParts parts= new ScrapeCriteriaParts();
            parts.Regex = _regex;
            parts.RegexOption = _regexOption;
            return parts;
        }
    }
}
