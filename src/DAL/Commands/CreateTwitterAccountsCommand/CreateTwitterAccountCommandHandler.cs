using Core.Commands;

namespace DAL.Commands.CreateTwitterAccountCommand
{
    public class CreateTwitterAccountCommandHandler : ICommandHandler<CreateTwitterAccountCommand>
    {
        public Task HandleAsync(CreateTwitterAccountCommand command, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
