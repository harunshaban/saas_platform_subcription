using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saas_platform_subcription.Models
{
    public class Country
    {
        public int id { get; set; }
        public string countryName { get; set; }

        public int regionId { get; set; }

        public virtual Region region { get; set; }

    }
}