using System.Collections.Generic;
using TwitterLikeApp.Entity;

namespace TwitterLikeApp.UI.ViewModel
{
    public class BuddiesViewModel
    {
        public User User { get; set; }
        public IEnumerable<User> Buddies { get; set; }
    }
}