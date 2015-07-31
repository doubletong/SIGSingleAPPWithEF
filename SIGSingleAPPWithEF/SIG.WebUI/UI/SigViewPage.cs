using SIG.Data;
using SIG.Models;
using SIG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIG.Ui
{
    public abstract class SigViewPage : WebViewPage
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }

        public SigViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
        }
    }

    public abstract class SigViewPage<TModel> : WebViewPage<TModel>
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }

        public SigViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
        }
    }
}