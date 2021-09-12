using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website_challenge.Models
{
    public class Feature : BaseModel
    {
        public string Name { get; set; }
        public IList<ServiceFeatures> ServiceFeatures { get; set; }

    }
}
