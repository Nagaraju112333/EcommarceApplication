using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace ArchentsFirstProject
{
    public class ShopingCartModel
    {
        public int ItemId { get;set; }
        public  int Quantity { get;set; }
        public string ItemName { get;set; } 
        public string Description { get;set; }
        public int price { get;set; }
        public int UnitPrice { get; set; }  
        public int TotalPrice { get; set; }
    }
}