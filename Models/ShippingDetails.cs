using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACMEINCStore.Models
{
    public class ShippingDetails
    {
        public int ShippingDetails_Id { get; set; }
        [Required]
        public Nullable<int> Member_Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public Nullable<int> Order_Id { get; set; }
        public Nullable<decimal> Amount_Paid { get; set; }
        [Required]
        public string Payment_Type { get; set; }
    }
}