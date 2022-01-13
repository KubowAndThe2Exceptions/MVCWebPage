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
            var context = new ApplicationDbContext();
            var userIndex = context.Users.ToList();
            
            return View(userIndex);
        }
    }
}