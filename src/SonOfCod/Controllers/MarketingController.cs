using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class MarketingController : Controller
    {
        private ApplicationDbContext _db;
        public MarketingController(ApplicationDbContext db)
        {
            _db = db;
        }
        public MarketingController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
