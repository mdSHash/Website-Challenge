using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website_challenge.Models
{
    public class OrderService : BaseModel
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}
