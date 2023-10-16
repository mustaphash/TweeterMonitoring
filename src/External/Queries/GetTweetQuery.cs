using Core.Models;
using Newtonsoft.Json;

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
            HttpResponseMessage response = await httpClient.GetAsync("https://api.twitter.com/2/users/by?usernames=twitterdev,twitterapi,adsapi&user.fields=created_at&expansions=pinned_tweet_id&tweet.fields=author_id,created_at");
            string content = await response.Content.ReadAsStringAsync();

            var tweets = JsonConvert.DeserializeObject<List<Tweet>>(content);
            List<Tweet> tweetUrl = tweets.Where(t => t.Type.Contains(tweet)).ToList();

            return tweetUrl;
        }
    }
}
