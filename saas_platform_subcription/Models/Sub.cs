using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saas_platform_subcription.Models
{
    public class Sub
    {
        public int id { get; set; }
        public string subName { get; set; }
        public decimal vat { get; set; }
        public decimal price { get; set; }
        public decimal pricewithvat
        {
            get
            {
                return (((price * vat)/100) + price);
            }
        }
        public decimal yearly
        {
            get
            {
                return pricewithvat * 12;
            }
        }
    }
}