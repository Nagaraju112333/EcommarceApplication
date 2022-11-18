﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ActionResult Geta()
        {
            return View();
        }
     
    }
}