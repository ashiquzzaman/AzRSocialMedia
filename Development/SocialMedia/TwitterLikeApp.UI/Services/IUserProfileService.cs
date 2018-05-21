using TwitterLikeApp.Entity;
using TwitterLikeApp.UI.ViewModel;

namespace TwitterLikeApp.UI.Services
{
    public interface IUserProfileService
    {
        UserProfile GetBy(int id);
        void Update(EditProfileViewModel model);
    }
}