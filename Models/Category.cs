using System;

namespace quotingdojo.Models
{
    public class Category : BaseEntity
    {
        public int quoteid { get; set; }
        public string quote { get; set; }
        public int metaid { get; set; }
        public int authorid { get; set; }
    }
}