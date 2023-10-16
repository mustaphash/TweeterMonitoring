using Core.Entities;

namespace TwitterMonitoringWebApp.Models.TwitterAccountModels
{
    public class CreateTwitterAccountModel
    {
        public string Url { get; set; }

        public int TweetId { get; set; }

        public DateTime TweetDate { get; set; }

        public TwitterAccount ToTwitterAccount()
        {
            return new TwitterAccount
            {
                Url = this.Url,
                TweetId = this.TweetId,
                TweetDate = this.TweetDate
            };
        }
    }
}
