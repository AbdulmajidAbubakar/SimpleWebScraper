using SimpleWebScraper.builders;
using SimpleWebScraper.data;
using SimpleWebScraper.workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    internal class Program
    {
        public static String method = "search";
        static void Main(string[] args)
        {
            try {

                Console.WriteLine("enter the name of the city");
                String city = Console.ReadLine();
                Console.WriteLine("enter the craigslist category you will want to scrape");
                String category= Console.ReadLine();
                using (WebClient webClient = new WebClient())
                {
                    String content = webClient.DownloadString($"http://{city.Replace(" ", String.Empty)}.craigslist.org/{method}/{category}");
                    Console.WriteLine(content);
                    ScrapeCriteria criteria = new ScrapeCriteriaBuilder()
                        .withData(content)
                        .withRegex(@"<p>(.*?)<\/p>>")
                        .withRegexOption(RegexOptions.ExplicitCapture)
                        .withParts(new ScrapeCriteriaPartBuilder()
                            .withRexex(@">(.*?)").withRegexOption(RegexOptions.Singleline)
                            .build())
                        .withParts(new ScrapeCriteriaPartBuilder()
                            .withRexex(@" href=\""(.*?)\""").withRegexOption(RegexOptions.Singleline)
                            .build())
                        .build();
                    Scraper scraper = new Scraper();

                    var scrapedelement = scraper.Scrape(criteria);
                    if (scrapedelement.Any())
                    {
                        foreach (var element in scrapedelement)
                        {
                            Console.WriteLine(element);
                        }
                    }
                    else
                    {
                        Console.WriteLine("there were no matches");
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
