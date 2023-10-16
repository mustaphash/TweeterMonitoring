using Core.Models;

namespace External.Queries.Interfaces
{
    public interface IGetTweetQuery
    {
        Task<List<Tweet>> ExecuteAsync(string tweet);
    }
}
