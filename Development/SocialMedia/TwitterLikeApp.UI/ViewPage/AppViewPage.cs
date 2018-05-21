using System.Web.Mvc;
using TwitterLikeApp.Entity;
using TwitterLikeApp.UI.Models;
using TwitterLikeApp.UI.Services;

namespace TwitterLikeApp.UI.ViewPage
{

  public abstract class AppViewPage : WebViewPage
  {
      protected IContext DataContext;
      public User CurrentUser { get; private set; }
      public IUserService Users { get; private set; }
      public ISecurityService Security { get; private set; }

      public AppViewPage()
      {
          DataContext = new Context();
          Users = new UserService(DataContext);
          Security = new SecurityService(Users);
          CurrentUser = Security.GetCurrentUser();
      }
  }

  public abstract class AppViewPage<TModel> : WebViewPage<TModel>
  {
      protected IContext DataContext;
      public User CurrentUser { get; private set; }
      public IUserService Users { get; private set; }
      public ISecurityService Security { get; private set; }

      public AppViewPage()
      {
          DataContext = new Context();
          Users = new UserService(DataContext);
          Security = new SecurityService(Users);
          CurrentUser = Security.GetCurrentUser();
      }
  }
}
