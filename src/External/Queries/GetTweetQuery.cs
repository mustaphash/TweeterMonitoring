using Core.Models;

namespace External.Queries
{
    public class GetTweetQuery
    {
        private readonly Context _httpClientContext;

        public GetTweetQuery()
            : this(new Context())
        {
        }

        public GetTweetQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<List<Tweet>> ExecuteAsync(string tweet)
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync("");
            string content = await response.Content.ReadAsStringAsync();


        }
    }
}
