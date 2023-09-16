using MVCSearchFunctionality.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSearchFunctionality.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ApplicationDbContext _db=new ApplicationDbContext();
        public ActionResult Index(string searchBy,string search)
        {
            if (searchBy == "Name")
            {
                var data1=_db.Students.Where(u=>u.Name == search).ToList();
                return View(data1);
            }
            if (searchBy == "Gender")
            {
                var data2 = _db.Students.Where(u => u.Gender == search).ToList();
                return View(data2);
            }
            var data=_db.Students.ToList();
            return View(data);
        }
    }
}