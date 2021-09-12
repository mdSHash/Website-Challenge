using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Website_challenge.Enums
{
    public enum OrderType
    {
        [Display(Name = "T")]
        T = 1,
        [Display(Name = "S")]
        S,
        [Display(Name = "F")]
        F
    }
}
