using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
          return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string cityName, string imgUrl)
        {
          Place newPlace = new Place(cityName, imgUrl);
          return RedirectToAction("Index");
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
          Place.ClearAll();
          return View();
        }

        [HttpGet("/places/{id}")]
        public ActionResult Show(int id)
        {
          Place aPlace = Place.Find(id);
          return View(aPlace);
        }
    }
}
