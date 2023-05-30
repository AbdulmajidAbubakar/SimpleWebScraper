using SimpleWebScraper.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.workers
{
    public class Scraper
    {
        public List<string> Scrape(ScrapeCriteria scrapeCriteria) {
            List<string> scrapedElements= new List<string>();
            MatchCollection matches = Regex.Matches(scrapeCriteria.Data, scrapeCriteria.Regex, scrapeCriteria.RegexOption);
            foreach (Match match in matches)
            {
                if (!scrapeCriteria.parts.Any())
                {
                    scrapedElements.Add(match.Value);
                }
                else
                {
                    foreach(var part in scrapeCriteria.parts) { 
                    Match matchedpart= Regex.Match(match.Groups[0].Value, part.Regex, part.RegexOption);
                    if (matchedpart.Success)
                        {
                            scrapedElements.Add(matchedpart.Groups[1].Value);
                        }
                    }
                }
            }
            return scrapedElements;
        }
    }
}
