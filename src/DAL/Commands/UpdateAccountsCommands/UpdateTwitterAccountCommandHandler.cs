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
            var twitterAccounts = _twitterContext.TwitterAccounts.FirstOrDefault(t => t.TweetId == command.TweetId);

            if (twitterAccounts != null)
            {
                twitterAccounts.UserName = command.TwitterAccount.UserName;
                twitterAccounts.Url = command.TwitterAccount.Url;
                twitterAccounts.TweetDate = command.TwitterAccount.TweetDate;

                await _twitterContext.SaveChangesAsync();
            }
        }
    }
}
