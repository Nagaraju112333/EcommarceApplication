//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchentsFirstProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public string Category_Image { get; set; }
        public string Category_Description { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
