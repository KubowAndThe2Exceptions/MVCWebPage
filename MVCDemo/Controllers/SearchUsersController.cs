using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class SearchUsersController : Controller
    {
        public SearchUsersController()
        {
        }
        // GET: SearchUsers
        public ActionResult Index()
        {
            var userIndex = new List<ApplicationUser>();
            
            //try both designs
            using (var context = new ApplicationDbContext())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                // var altusers = context.Users.ToList();

                var users = userManager.Users.ToList();

                foreach (var user in users)
                {
                    userIndex.Add(user);
                }
            }

            return View(userIndex);
        }
    }
}