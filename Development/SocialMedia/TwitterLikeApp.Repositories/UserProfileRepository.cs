using System.Data.Entity;
using TwitterLikeApp.Entity;

namespace TwitterLikeApp.Repositories
{
    public class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DbContext context, bool sharedContext) : base(context, sharedContext) { }
    }
}