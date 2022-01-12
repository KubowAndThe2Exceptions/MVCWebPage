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
        private ApplicationDbContext _appDb;
        public SearchUsersController(ApplicationDbContext appDb)
        {
            _appDb = appDb;
        }
        // GET: SearchUsers
        public ActionResult Index()
        {

            return View(_appDb.Users.ToList());
        }
    }
}