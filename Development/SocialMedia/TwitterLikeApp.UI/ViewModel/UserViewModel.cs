using System.Collections.Generic;
using TwitterLikeApp.Entity;

namespace TwitterLikeApp.UI.ViewModel
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IEnumerable<Ribbit> Ribbits { get; set; }
    }
}