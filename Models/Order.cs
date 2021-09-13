using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Website_challenge.Models
{
    public class Order : BaseModel
    {
        public static int Order_number { get; set; }
        [Display(Name = "Order Quatity")]
        [Range(1, 5, ErrorMessage = "Order Quatity must be between 1 - 5")]
        public int Quatity { get; set; }
        [NotMapped]
        [Display(Name = "Services")]
        public List<int> ServicesId { get; set; } = new List<int>();
        [NotMapped]
        [Display(Name = "Features")]
        public List<int> FeaturesId { get; set; } = new List<int>();
        public List<OrderService> OrderServices { get; set; } = new List<OrderService>();
        public List<OrderFeature> OrderFeatures { get; set; } = new List<OrderFeature>();
        public DateTime RequestedDeliveryTime { get; set; }
    }
}
