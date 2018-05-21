using System;
using TwitterLikeApp.Repositories;

namespace TwitterLikeApp.UI.Models
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IRibbitRepository Ribbits { get; }
        IUserProfileRepository Profiles { get; }
        int SaveChanges();
    }
}
