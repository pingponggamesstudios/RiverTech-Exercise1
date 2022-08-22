using System;
using System.Collections.Generic;
using System.Text;

namespace RiverTech___Exercise_1__Web_API_.Models
{
    public class Address
    {

        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public decimal Zipcode { get; set; }

        public Geo geo { get; set; }
    }
}
