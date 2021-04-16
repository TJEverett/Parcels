using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult HomePage() { return View(); }

    [Route ("/order")]
    public ActionResult ParcelForm() { return View(); }

    [Route ("/check")]
    public ActionResult PriceCheck(double length, double width, double height, double weight)
    {
      if(length == 0 || width == 0 || height == 0 || weight == 0)
      {
        return RedirectToAction("Error");
      }
      else
      {
        Parcel package = new Parcel(length, width, height, weight);
        return View(package);
      }
    }

    [Route ("/error")]
    public ActionResult Error() { return View(); }
  }
}