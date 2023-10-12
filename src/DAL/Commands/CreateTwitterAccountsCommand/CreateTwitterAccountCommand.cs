using Core.Commands;
using Core.Entities;

namespace DAL.Commands.CreateTwitterAccountsCommand
{
    public class CreateTwitterAccountCommand : ICommand
    {
        public CreateTwitterAccountCommand(TwitterAccount twitterAccount)
        {
            TwitterAccount = twitterAccount;
        }

        public TwitterAccount TwitterAccount { get; set; }
    }
}
