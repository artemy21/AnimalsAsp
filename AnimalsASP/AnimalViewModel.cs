using LibCore.Models;
using LibApplication.Commands;

namespace AnimalsASP
{
	public class AnimalViewModel
	{
		public Animal? Animal { get; set; }
		public CreateCommentCommand? CommentCommand { get; set; }

		public AnimalViewModel(Animal animal, CreateCommentCommand commentCommand)
		{
			Animal = animal;
			CommentCommand = commentCommand;
		}
	}
}
