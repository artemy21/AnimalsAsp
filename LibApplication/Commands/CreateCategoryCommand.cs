using MediatR;
using LibCore.Models;
using System.ComponentModel.DataAnnotations;

namespace LibApplication.Commands
{
    public class CreateCategoryCommand : IRequest<Category>
    {
        [Required]
        public string? Name { get; set; }
    }
}
