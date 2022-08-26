using System;
using System.Collections.Generic;
using System.Text;

namespace RiverTech___Exercise_1__Web_API_.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        public Company company { get; set; }
    }
}
