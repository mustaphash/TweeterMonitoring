using Core.Entities;

namespace TwitterMonitoringWebApp.Models.TwitterAccountModels
{
    public class UpdateTwitterAccountModel
    {
        public string Url { get; set; }

        public int TweetId { get; set; }

        public DateTime TweetDate { get; set; }

        public TwitterAccount ToUpdate()
        {
            return new TwitterAccount
            {
                Url = Url,
                TweetId = TweetId,
                TweetDate = TweetDate
            };
        }
    }
}
