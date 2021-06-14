using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACMEINCStore.Models
{
    public class CategoryDetails
    {
        public int Category_Id { get; set; }
        [Required(ErrorMessage ="Category Name Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and Maximum 100 Characters Are Allowed", MinimumLength = 3)]
        public string Category_Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class ProductDetails
    {
        public int Product_Id { get; set; }
        [Required(ErrorMessage ="Product Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and Maximum 100 Characters Are Allowed", MinimumLength = 3)]
        public string Product_Name { get; set; }
        [Required]
        [Range(1, 50)]
        public Nullable<int> Category_Id { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        [Required(ErrorMessage ="Description is Required")]
        public Nullable<System.DateTime> Description { get; set; }
        public string Product_Image { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        [Range(typeof(int), "1", "500", ErrorMessage ="Invalid Quantity")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "200000", ErrorMessage = "Invalid Price")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }
    }
}