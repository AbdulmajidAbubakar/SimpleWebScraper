# SimpleWebScraper
This is a simple web scraper implemented in C# that allows you to scrape data from Craigslist's city-specific pages.

How it Works
When you run the program, you will be prompted to enter the name of the city and the Craigslist category you want to scrape. The program will then send a request to the specified Craigslist page and download the HTML content of that page.

The content is parsed using the defined scrape criteria, which is set up to specifically capture parts of the HTML using regular expressions. The scrape criteria are built to capture all paragraph text and all href attributes within the HTML.

Finally, the program prints out the scraped elements. If there are no matches for the scrape criteria, it will let you know.
