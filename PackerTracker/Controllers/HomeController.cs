using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
      public ActionResult Index() { return View(); }

      [HttpGet("/unpackeditem/new")]
      public ActionResult PackForm() { return View(); }

      [HttpPost("/packedlist")]
      public ActionResult PackedForm(string item) 
      {
          Packed newPacked = new Packed(item);
          List<Packed> allItems = Packed.GetAll();
          return View("PackList", allItems); }
  }
}