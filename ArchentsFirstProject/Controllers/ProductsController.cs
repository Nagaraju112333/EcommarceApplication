using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using ArchentsFirstProject.Models;
using Microsoft.Ajax.Utilities;

namespace ArchentsFirstProject.Controllers
{
    public class ProductsController : Controller
    {
        
        // GET: Products
        ArchentsEntities4 db=new ArchentsEntities4();   
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult WeeknedBoots(int id)
        {
            ViewBag.size=GetSizes(id);
            ViewBag.data = db.Products1.FirstOrDefault(x => x.Product_Id == id);
            return View();
        }
        [HttpPost]
        public ActionResult WeeknedBoots(Products1 pro)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Review(Review rev)
        {
            db.Reviews.Add(rev);
            db.SaveChanges();
            return RedirectToAction("WeeknedBoots");
           
        }
        public List<size> GetSizes(int id)
        {
            var result=db.sizes.Where(x=>x.ProductId==id).ToList();
            return result;
        }
        private List<ShopingCartModel> listofshopingcart = new List<ShopingCartModel>();
        [HttpPost]
        public  JsonResult ProductPost(string ItemId)
        {
            ShopingCartModel list1 = new ShopingCartModel();
            Products1 productsss = db.Products1.Single(model => model.Product_Id.ToString()== ItemId);
            if (Session["CardCounter"] != null)
            {
                listofshopingcart = Session["Carditgem"] as List<ShopingCartModel>;
            }
            if (listofshopingcart.Any(model => model.ItemId.ToString() == ItemId))
            {
                list1 = listofshopingcart.Single(model => model.ItemId.ToString() == ItemId);
                list1.Quantity = list1.Quantity + 1;
                list1.TotalPrice = list1.Quantity + list1.UnitPrice;
            }
            else
            {
                list1.ItemId = Convert.ToInt32( ItemId);
                list1.ItemName = productsss.Product_Name;
                list1.Description=productsss.product_Description;
                list1.price = Convert.ToInt32( productsss.Price);
                list1.Quantity = 1;
                list1.UnitPrice = Convert.ToInt32( productsss.Price);
                listofshopingcart.Add(list1);
            }
            Session["CardCounter"] = listofshopingcart.Count;
            Session["Carditgem"] = listofshopingcart;
            return Json(data:new {success=true,Counter=listofshopingcart.Count},JsonRequestBehavior.AllowGet);
        }
     
    }
}