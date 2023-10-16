using Core.Entities;

namespace TwitterMonitoringWebApp.Models.TwitterAccountModels
{
    public class UpdateTwitterAccountModel
    {
        public string UserName { get; set; }

        public string Url { get; set; }

        public DateTime TweetDate { get; set; }

        public TwitterAccount ToUpdate()
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
