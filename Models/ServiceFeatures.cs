using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website_challenge.Models
{
    public class ServiceFeatures
    {
        public int ServiceId { get; set; }
        public  Service service { get; set; }

        public int FeatureId { get; set; }
        public Feature feature { get; set; }
    }
}
