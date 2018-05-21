using System.Web.Mvc;
using TwitterLikeApp.UI.ViewModel;

namespace TwitterLikeApp.UI.Controllers
{
    public class ProfileController : BaseController
    {

        public ActionResult Index()
        {
            if (!Security.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var profile = Profiles.GetBy(CurrentUser.UserProfileId);

            return View(new EditProfileViewModel()
            {
                Bio = profile.Bio,
                Email = profile.Email,
                Id = profile.Id,
                Name = profile.Name,
                Website = profile.WebsiteUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditProfileViewModel model)
        {
            if (!Security.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            Profiles.Update(model);

            return RedirectToAction("Index");

        }
    }
}