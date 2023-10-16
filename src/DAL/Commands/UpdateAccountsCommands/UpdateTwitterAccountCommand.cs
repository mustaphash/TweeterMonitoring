using Core.Commands;
using Core.Entities;

namespace DAL.Commands.UpdateAccountsCommands
{
    public class UpdateTwitterAccountCommand : ICommand
    {
        public UpdateTwitterAccountCommand(int tweetId, TwitterAccount twitterAccount)
        {
            TweetId = tweetId;
            TwitterAccount = twitterAccount;
        }

        public int TweetId { get; set; }

        public TwitterAccount TwitterAccount { get; set; }
    }
}
