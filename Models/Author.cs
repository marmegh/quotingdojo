using System;

namespace quotingdojo.Models
{
    public class Author : BaseEntity
    {
        public int authorid { get; set; }
        public string name { get; set; }
    }
}