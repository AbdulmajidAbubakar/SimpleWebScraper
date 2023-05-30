using SimpleWebScraper.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.builders
{
    public class ScrapeCriteriaBuilder
    {
    

        private String _data;
        private String _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaParts> _parts;

        public ScrapeCriteriaBuilder()
        {
      

            setDefault();
        }

        private void setDefault()
        {
            _data = String.Empty;
            _regex = String.Empty;
            _regexOption = RegexOptions.None;
            _parts= new List<ScrapeCriteriaParts>();
        }

        public ScrapeCriteriaBuilder withData(String data)
        {
            _data = data;
            return this;
        }
        public ScrapeCriteriaBuilder withRegex(String regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaBuilder withRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }
        public ScrapeCriteriaBuilder withParts(ScrapeCriteriaParts parts)
        {
            _parts.Add(parts) ;
            return this;
        }
        public ScrapeCriteria build()
        {
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = _data;
            scrapeCriteria.Regex = _regex;
            scrapeCriteria.RegexOption= _regexOption;
            scrapeCriteria.parts = _parts;
            return scrapeCriteria;
        }
    }
}
