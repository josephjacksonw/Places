using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class LocationsController : Controller
  {
    [HttpGet("/locations")] // at the page locations
    public ActionResult Index()
    {
      List<Location> allLocactions = Location.GetAll(); //will get a list of all locations so far by just calling the already existing one
      return View(allLocactions);
    }

    [HttpGet("/locations/new")] // for making a new location
    public ActionResult CreateForm() //does this take us to the CreateForm.cshtml?
    {
      return View();
    }
    [HttpPost("/locations")]
    public ActionResult Create(string description, int days, string journal)
    {
      Location myLocation = new Location(description, days, journal);
      return RedirectToAction("Index"); //redirects to the index.cshtml after the user input of description
    }
    [HttpPost("/locations/delete")]
    public ActionResult DeleteAll()
    {
      Location.ClearAll();
      return View();
    }
  }
}