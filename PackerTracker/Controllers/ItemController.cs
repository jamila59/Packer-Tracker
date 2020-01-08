using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemController : Controller
  {
      [HttpGet("/unpackedform")]//First main user page;
      public ActionResult UnpackedForm() { return View(); }

      [HttpPost("/unpackedlist")]
      public ActionResult UnpackedList(string item) 
      {
          Packed newUnPacked = new Packed(item);
          List<Packed> allItems = Packed.GetAll();
          return View("UnpackedList", allItems); }
  }
}