using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class MarketingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private readonly UserManager<ApplicationUser> _userManager;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewAll()
        {
            return View(db.Inventory.OrderByDescending(Inventory => Inventory.Cost).ToList());
        }
        public IActionResult SignUp()
        {
            //var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var currentUser = await _userManager.FindByIdAsync(userId);
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(MailingList mailingList)
        {
            db.MailingList.Add(mailingList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Recipients()
        {
            return View(db.MailingList.OrderByDescending(MailingList => MailingList.LastName).ToList());
        }
    }
}
