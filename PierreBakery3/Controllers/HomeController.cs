using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Bakery.ViewModels;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
      private readonly BakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public HomeController(UserManager<ApplicationUser> userManager, BakeryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        FlavorTreatViewModel model = new FlavorTreatViewModel();
        model.flavorList = _db.Flavors.ToList();
        model.treatList =_db.Treats.ToList();
        return View(model);
      }
    }
}