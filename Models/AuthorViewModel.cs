using System.ComponentModel.DataAnnotations;

namespace quotingdojo.Models
{
    public class AuthorViewModel : BaseEntity
    {
        [Required]
        [MinLength(3)]
        public string name { get; set; }
    }
}