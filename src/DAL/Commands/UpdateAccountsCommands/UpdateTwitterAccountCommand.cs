using Core.Commands;
using Core.Entities;

namespace DAL.Commands.UpdateAccountsCommands
{
    public class UpdateTwitterAccountCommand : ICommand
    {
        public UpdateTwitterAccountCommand(string userName, TwitterAccount twitterAccount)
        {
            UserName = userName;
            TwitterAccount = twitterAccount;
        }

        public string UserName { get; set; }

        public TwitterAccount TwitterAccount { get; set; }
    }
}
