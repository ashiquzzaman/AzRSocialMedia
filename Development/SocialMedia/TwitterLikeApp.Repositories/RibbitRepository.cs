using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TwitterLikeApp.Entity;

namespace TwitterLikeApp.Repositories
{
  public  class RibbitRepository:Repository<Ribbit>,IRibbitRepository
  {
      public RibbitRepository(DbContext context, bool sharedContext)
          : base(context, sharedContext) { }

      public Ribbit GetBy(int id)
      {
          return Find(r => r.Id == id);
      }

      public IEnumerable<Ribbit> GetFor(User user)
      {
          return user.Ribbits.OrderByDescending(r => r.DateCreated);
      }

      public void AddFor(Ribbit ribbit, User user)
      {
          user.Ribbits.Add(ribbit);

          if (!ShareContext)
          {
              Context.SaveChanges();
          }
      }
  }
}
