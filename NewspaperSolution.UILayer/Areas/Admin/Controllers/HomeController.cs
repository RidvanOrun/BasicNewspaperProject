using NewspaperSolution.DataAccessLayer.Repository.Concrete.EfRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewspaperSolution.UILayer.Areas.Admin.Controllers
{
    
    public class HomeController : Controller
    {
        EfPostRepository _postREpository;
        public HomeController()
        {
            _postREpository = new EfPostRepository(); 
        }

        // GET: Admin/Home
        public ActionResult Index()
        {

            return View();
        }
    }
}