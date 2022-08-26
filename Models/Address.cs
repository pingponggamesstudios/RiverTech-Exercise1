namespace RiverTech___Exercise_1__Web_API_.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        public Geo geo { get; set; }
    }
}
