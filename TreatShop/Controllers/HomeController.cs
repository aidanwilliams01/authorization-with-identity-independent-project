using TreatShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {

    private readonly TreatShopContext _db;

    public HomeController(TreatShopContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Flavor[] flavs = _db.Flavors.ToArray();
      Treat[] treats = _db.Treats.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("flavors", flavs);
      model.Add("treats", treats);
      return View(model);
    }
  }
}
