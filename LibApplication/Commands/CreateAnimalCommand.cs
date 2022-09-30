using MediatR;
using LibCore.Models;
using System.ComponentModel.DataAnnotations;

namespace LibApplication.Commands
{
    public class CreateAnimalCommand : IRequest<Animal>
    {
        [Required]
        [StringLength(20)]
        public string? Name { get; set; }
        [Required]
        [StringLength(100)]
        public string? Description { get; set; }
        [Required]
        [Url]
        public string? ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
