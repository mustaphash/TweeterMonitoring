using Core.Commands;

namespace DAL.Commands.UpdateAccountsCommands
{
    public class UpdateTwitterAccountCommandHandler : ICommandHandler<UpdateTwitterAccountCommand>
    {
        private readonly TwitterContext _twitterContext;

        public UpdateTwitterAccountCommandHandler(TwitterContext twitterContext)
        {
            _twitterContext = twitterContext;
        }

        public async Task HandleAsync(UpdateTwitterAccountCommand command, CancellationToken cancellationToken = default)
        {
            var twitterAccounts = _twitterContext.TwitterAccounts.FirstOrDefault(t => t.UserName == command.UserName);

            if (twitterAccounts != null)
            {
                twitterAccounts.Url = command.TwitterAccount.Url;
                twitterAccounts.TweetId = command.TwitterAccount.TweetId;
                twitterAccounts.TweetDate = command.TwitterAccount.TweetDate;

                await _twitterContext.SaveChangesAsync();
            }
        }
    }
}
