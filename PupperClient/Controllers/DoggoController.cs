using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PupperClient.Models;


namespace PupperClient.Controllers
{
  public class DoggosController : Controller
  {
    public IActionResult Index()
    {
      var allDoggos = Doggo.GetDoggos();
      return View(allDoggos);
    }
  }
}