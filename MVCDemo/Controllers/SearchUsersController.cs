using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MVCDemo.Controllers
{
    public class SearchUsersController : Controller
    {
        public SearchUsersController()
        {
        }
        // GET: SearchUsers
        public ViewResult Index(int? page)
        {
            var context = new ApplicationDbContext();
            var userIndex = context.Users.ToList();

            int pageNumber = 1;
            int pageSize = 1;

            if (page.HasValue)
            {
                pageNumber = (int)page;
            }

            return View(userIndex.ToPagedList(pageNumber, pageSize));
        }
    }
}