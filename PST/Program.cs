using NewsAPI;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace PST
{
    class Program
    {
        public static NewsApiClient _client = new NewsApiClient("Bearer 62b9490e94e341059f6d2c2981bdd57d");
        public static string language = "en";
        public static string country = "us";

        static void Main(string[] args)
        {
            Console.WriteLine("Program starter Guide:");
            GetHelp();
            ReadInput();
        }

        private static void ReadInput()
        {
            var input = Console.ReadLine();
            switch (input.ToLower().Trim())
            {
                case "/topheadlines":
                    GetTopHeadlines();
                    break;
                case "/help":
                    GetHelp();
                    break;
                case "/search":
                    GetSearch();
                    break;
                case "/sources":
                    GetSources();
                    break;
                case "/changelanguage":
                    ChangeLanguage();
                    break;
                case "/changecountry":
                    ChangeCountry();
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    ReadInput();
                    break;
            }
        }

        private static void GetTopHeadlines()
        {
            var client = new RestClient($"https://newsapi.org/v2/top-headlines?country={country}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            var articles = JsonConvert.DeserializeObject<ArticleCollection>(response.Content);
            var i = 0;
            foreach (var article in articles.Articles)
            {
                Console.WriteLine($"{i++}. {article.Title}");
            }
            Console.WriteLine("--------------------------------------");
            SelectArticle(articles);
            ReadInput();
        }

        private static void ChangeLanguage()
        {
            Console.WriteLine("Enter new language code:");
            var input = Console.ReadLine();
            if (Enum.IsDefined((typeof(LanguageEnums)), input))
            {
                language = input;
            }
            else
            {
                Console.WriteLine("Invalid language code, possible Codes:");
                foreach (var languageEnum in Enum.GetValues(typeof(LanguageEnums)))
                {
                    Console.WriteLine(string.Format("{0}: {1}", Enum.GetName(typeof(LanguageEnums), languageEnum), languageEnum));
                }
            }
        }

        private static void ChangeCountry()
        {
            Console.WriteLine("Enter new country code:");
            var input = Console.ReadLine();
            if (Enum.IsDefined((typeof(CountryEnums)), input))
            {
                country = input;
            }
            else
            {
                Console.WriteLine("Invalid country code, possible Codes:");
                foreach(var countryEnum in Enum.GetValues(typeof(CountryEnums)))
                {
                    Console.WriteLine(String.Format("{0}: {1}", Enum.GetName(typeof(CountryEnums), countryEnum), countryEnum));
                }
            }
        }

        private static void GetSearch()
        {
            Console.WriteLine("!!!Search does not support country settings!!!");
            Console.WriteLine("Enter search keyword:");
            var input = Console.ReadLine();

            var client = new RestClient($"https://newsapi.org/v2/everything?q={input}?language={language}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            var articles = JsonConvert.DeserializeObject<ArticleCollection>(response.Content);
            var i = 0;
            foreach (var article in articles.Articles)
            {
                Console.WriteLine($"{i++}. {article.Title}");
            }
            Console.WriteLine("--------------------------------------");
            SelectArticle(articles);
            ReadInput();
        }

        private static void GetSources()
        {
            var client = new RestClient($"https://newsapi.org/v2/sources?language={language}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            var sources = JsonConvert.DeserializeObject<SourceCollection>(response.Content);
            var i = 0;
            foreach (var source in sources.Sources)
            {
                Console.WriteLine($"{i++}. {source.Name}");
            }
            Console.WriteLine("--------------------------------------");
            ReadInput();
        }

        private static void SelectArticle(ArticleCollection articles)
        {
            Console.WriteLine("Select article:");
            var input = Console.ReadLine();
            try
            {
                Console.WriteLine(articles.Articles[int.Parse(input)].Url);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format, just write the number of the article.");
            }
        }

        private static void GetHelp()
        {
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("/topHeadlines - Returns top headlines based on selected country.");
            Console.WriteLine("/help - Returns list of help commands.");
            Console.WriteLine("/search - Lets user search articles by keyword.");
            Console.WriteLine("/sources - Displays a list of sources.");
            Console.WriteLine("/changeLanguage - Changes language to display articles written in specified language");
            Console.WriteLine("/changeCountry - Changes the country setting for getting top headlines.");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::");
            ReadInput();
        }
    }
}
