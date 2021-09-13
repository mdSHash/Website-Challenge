using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Website_challenge.Models
{
    public class OrderFeature : BaseModel
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
