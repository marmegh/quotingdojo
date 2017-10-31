using System.ComponentModel.DataAnnotations;

namespace quotingdojo.Models
{
    public class AuthorViewModel : BaseEntity
    {
        [Required]
        [MinLength(6)]
        public string name { get; set; }
    }
}