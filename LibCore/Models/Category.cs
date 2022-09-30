using System.ComponentModel.DataAnnotations;

namespace LibCore.Models
{
    public class Category : Model
    {
        [Required]
        public string? Name { get; set; }
        public ICollection<Animal> Animals { get; private set; } = new List<Animal>();
    }
}
