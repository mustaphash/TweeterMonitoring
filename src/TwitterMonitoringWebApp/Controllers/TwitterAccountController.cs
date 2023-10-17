using Core.Commands;
using DAL.Commands.CreateTwitterAccountsCommands;
using DAL.Commands.UpdateAccountsCommands;
using Microsoft.AspNetCore.Mvc;
using TwitterMonitoringWebApp.Models.TwitterAccountModels;

namespace TwitterMonitoringWebApp.Controllers
{
    public class TwitterAccountController : ControllerBase
    {
        private readonly ICommandHandler<CreateTwitterAccountCommand> _createTwitterAccountCommand;
        private readonly ICommandHandler<UpdateTwitterAccountCommand> _updateTwitterAccountCommand;

        public TwitterAccountController(
            ICommandHandler<CreateTwitterAccountCommand> createTwitterAccountCommand,
            ICommandHandler<UpdateTwitterAccountCommand> updateTwitterAccountCommand)
        {
            _createTwitterAccountCommand = createTwitterAccountCommand;
            _updateTwitterAccountCommand = updateTwitterAccountCommand;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTwitterAccount(CreateTwitterAccountModel model)
        {
            var twitterAccount = model.ToTwitterAccount();
            await _createTwitterAccountCommand.HandleAsync(new CreateTwitterAccountCommand(twitterAccount));

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTwitterAccount(int tweetId, UpdateTwitterAccountModel model)
        {
            var twitterAccount = model.ToUpdate();
            await _updateTwitterAccountCommand.HandleAsync(new UpdateTwitterAccountCommand(tweetId, twitterAccount));

            return NoContent();
        }
    }
}
