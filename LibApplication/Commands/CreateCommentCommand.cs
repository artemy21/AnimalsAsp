using MediatR;
using LibCore.Models;
using System.ComponentModel.DataAnnotations;

namespace LibApplication.Commands
{
    public class CreateCommentCommand : IRequest<Comment>
    {
        [Required]
        [StringLength(50)]
        public string? Content { get; set; }
        [Required]
        public int AnimalId { get; set; }
    }
}
