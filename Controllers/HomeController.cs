using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using WorldData.Models;
using System.Collections.Generic;

namespace WorldData.Controllers
{
  public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View("Index");
      }
      [Route("/view-all-countries")]
      public ActionResult ViewAllCountries()
      {
        List<Country> myCountries = Country.GetAll();
        return View("ViewAllCountries", myCountries);
      }
      // [Route("/view-all-cities")]
      // public ActionResult ViewAllCities()
      // {
      //   List<Country> allCities = allCities.GetAll();
      //   return View("ViewAllCities");
      // }

    }

}
