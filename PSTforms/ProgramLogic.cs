using NewsAPI;
using Newtonsoft.Json;
using PST;
using RestSharp;

namespace PSTforms
{
    public class ProgramLogic
    {
        public static NewsApiClient _client = new NewsApiClient("Bearer 62b9490e94e341059f6d2c2981bdd57d");
        public static string Country = "US";
        public static string Language = "all";
        public static string Source = string.Empty;

        public ArticleCollection GetTopHeadlines()
        {
            RestClient client;
            if (string.IsNullOrEmpty(Source))
            {
                client = new RestClient($"https://newsapi.org/v2/top-headlines?Country={Country}&pageSize=100");
            }
            else
            {
                client = new RestClient($"https://newsapi.org/v2/top-headlines?sources={Source}");
            }
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            var articles = JsonConvert.DeserializeObject<ArticleCollection>(response.Content);
            return articles;
        }

        public ArticleCollection GetTopHeadlines(string s)
        {
            RestClient client;
            if (string.IsNullOrEmpty(Source))
            {
                client = new RestClient($"https://newsapi.org/v2/top-headlines?q={s}&Country={Country}&pageSize=100");
            }
            else
            {
                client = new RestClient($"https://newsapi.org/v2/top-headlines?q={s}&sources={Source}");
            }
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            var articles = JsonConvert.DeserializeObject<ArticleCollection>(response.Content);
            return articles;
        }

        public bool ConnectionSuccess()
        {
            var client = new RestClient($"https://newsapi.org/v2/sources?apiKey=62b9490e94e341059f6d2c2981bdd57d");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            return response.IsSuccessful;
        }

        public ArticleCollection Search(string search)
        {
            RestClient client;
            if (string.IsNullOrEmpty(Source))
            {
                client = new RestClient($"https://newsapi.org/v2/everything?q={search}&pageSize=100");
            }
            else
            {
                var temp = Source.ToLower().Replace(" ", "-");
                client = new RestClient($"https://newsapi.org/v2/everything?q={search}&pageSize=100&sources={temp}");
            }
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                client = new RestClient($"https://newsapi.org/v2/everything?q=a&pageSize=100");
                response = client.Execute(request);
            }
            var articles = JsonConvert.DeserializeObject<ArticleCollection>(response.Content);
            return articles;
        }

        public SourceCollection GetSources()
        {
            var client = new RestClient($"https://newsapi.org/v2/sources?pageSize=100");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 62b9490e94e341059f6d2c2981bdd57d");
            request.AddHeader("Cookie", "__cfduid=dc0da68034e4a0414e82416f3b4cb1fb51602659968");
            IRestResponse response = client.Execute(request);
            var sources = JsonConvert.DeserializeObject<SourceCollection>(response.Content);
            return sources;
        }
    }
}
