using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Noida.Authority.Repository.Models;
using Noida.Authority.DAL.EF;
using Noida.Authority.Repository.Account;
using Microsoft.Owin.Security;
using Microsoft.Owin.Host.SystemWeb;
using Noida.Authority.Identity;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
//using Microsoft.Owin.Security;
//using System.Web.Helpers;
//using Microsoft.AspNet.Identity;

namespace Noida.Authority.Controllers
{
    public class AccountController : Controller
    {
        private AccountRepository accountRepository;
        private NoidaMigrationEntities dbContext;


        public AccountController()
        {
            accountRepository = new AccountRepository();
            dbContext = new NoidaMigrationEntities();
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel lvm)
        {
            var appDbContext = new ApplicationDbContext();
            var userStore = new ApplicationUserStore(appDbContext);
            var userManager = new ApplicationUserManager(userStore);
            //var user = userManager.Find(lvm.RegistrationId,lvm.Password);
            var user = dbContext.CustomerMsts.Find(lvm.RegistrationId, lvm.Password);

            if (user != null)
            {
                //login
                var authenticationManager = HttpContext.GetOwinContext().Authentication;
                //var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                //authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("myerror", "Invalid username or password");
                return View();
            }
        }
    }
}