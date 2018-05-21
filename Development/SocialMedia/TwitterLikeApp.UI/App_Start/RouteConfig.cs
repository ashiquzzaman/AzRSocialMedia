using System.Web.Mvc;
using System.Web.Routing;

namespace TwitterLikeApp.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //profile/{action}

            routes.MapRoute(
                name: "ProfileDefault",
                url: "profile/{action}",
                defaults: new {controller = "profile", action = "index"}
                );
            //account/{action}

            routes.MapRoute(
                name: "AccountDefault",
                url: "account/{action}",
                defaults: new {controller = "account"}
                );
            //Create Post
            routes.MapRoute(
                name: "Create",
                url: "create",
                defaults: new {controller = "home", action = "create"}
                );
            //Followers
            routes.MapRoute(
                name: "Followers",
                url: "followers",
                defaults: new {controller = "home", action = "followers"}
                );
            //Following
            routes.MapRoute(
                name: "Following",
                url: "following",
                defaults: new {controller = "home", action = "following"}
                );

            //Follow

            routes.MapRoute(
                name: "Follow",
                url: "follow",
                defaults: new {controller = "home", action = "follow"}
                );
            //Unfollow
            routes.MapRoute(
                name: "Unfollow",
                url: "unfollow",
                defaults: new {controller = "home", action = "unfollow"}
                );
            //Profiles
            routes.MapRoute(
                name: "Profiles",
                url: "profiles",
                defaults: new {controller = "home", action = "profiles"}
                );
            //UserDefault
            routes.MapRoute(
                name: "UserDefault",
                url: "{username}/{action}",
                defaults: new {controller = "user", action = "index"}
                );
            //Default
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new {controller = "home", action = "index"}
                );

        }
    }
}
