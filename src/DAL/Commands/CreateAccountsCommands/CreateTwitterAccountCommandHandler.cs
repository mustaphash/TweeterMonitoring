using Core.Commands;
using DAL.Commands.CreateTwitterAccountsCommands;

namespace DAL.Commands.CreateAccountCommands
{
    public class CreateTwitterAccountCommandHandler : ICommandHandler<CreateTwitterAccountCommand>
    {
        private readonly TwitterContext _twitterContext;

        public CreateTwitterAccountCommandHandler(TwitterContext twitterContext)
        {
            _twitterContext = twitterContext;
        }

        public async Task HandleAsync(CreateTwitterAccountCommand command, CancellationToken cancellationToken = default)
        {
            await _twitterContext.AddAsync(command.TwitterAccount);
            await _twitterContext.SaveChangesAsync();
        }
    }
}
