using Core.Entities;

namespace TwitterMonitoringWebApp.Models.TwitterAccountModels
{
    public class CreateTwitterAccountModel
    {
        public string UserName { get; set; }

        public string Url { get; set; }

        public DateTime TweetDate { get; set; }

        public TwitterAccount ToTwitterAccount()
        {
            return new TwitterAccount
            {
                UserName = UserName,
                Url = Url,
                TweetDate = TweetDate
            };
        }
    }
}
