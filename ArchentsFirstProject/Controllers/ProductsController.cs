using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArchentsFirstProject.Models;
namespace ArchentsFirstProject.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ArchentsEntities2 db=new ArchentsEntities2();   
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult WeeknedBoots()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WeeknedBoots(Product Pro)
        {
            return View();
        }
    }
}