using System.ComponentModel.DataAnnotations;

namespace LibCore.Models
{
    public class Comment : Model
    {
        public virtual Animal Animal { get; set; } = null!;
        [Required]
        public int AnimalId { get; set; }
        [Required]
        public string? Content { get; set; }
    }
}
