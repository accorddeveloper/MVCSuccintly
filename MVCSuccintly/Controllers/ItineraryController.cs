using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSuccintly.Models;

namespace MVCSuccintly.Controllers
{
    public class ItineraryController : Controller
    {
        public ActionResult Create()
        {
            var model = new ItineraryItem();
            return View(model);
        }

        [HttpPost] // filtro che istruisce il framework che questa azione del controller potrà essere chiamata solo da una POST
        public ActionResult Create(ItineraryItem data)
        {
            if(ModelState.IsValid)
            {
                // Handle saving the data only if the model state is valid
            }
            else
            {
                ModelState.AddModelError("", "The data you entered was not valid"); // Se l'utente inserisce dati non validi
            }
            return View();
        }
    }
}