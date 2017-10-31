using System;

namespace quotingdojo.Models
{
    public abstract class BaseEntity{}
    public class Quote : BaseEntity
    {
        public int quoteid { get; set; }
        public string quote { get; set; }
        public int metaid { get; set; }
        public int authorid { get; set; }
    }
}