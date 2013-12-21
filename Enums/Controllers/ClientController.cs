using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Enums.Models;

namespace Enums.Controllers
{
    public class ClientController : Controller
    {
        // GET: /Client/Create
        public ActionResult Create()
        {
            return View();
        }

         // POST: /Client/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            ViewBag.type = client.ClientType;
            return View();
        } 
    }
}
