using System.Collections.Generic;
using TwitterLikeApp.Entity;

namespace TwitterLikeApp.Repositories
{
    public interface IRibbitRepository :IRepository<Ribbit>
    {
        Ribbit GetBy(int id);
        IEnumerable<Ribbit> GetFor(User user);
        void AddFor(Ribbit ribbit, User user);
    }
}
